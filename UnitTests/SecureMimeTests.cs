//
// SecureMimeTests.cs
//
// Author: Jeffrey Stedfast <jeff@xamarin.com>
//
// Copyright (c) 2013 Jeffrey Stedfast
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;

using NUnit.Framework;

using MimeKit;
using MimeKit.Cryptography;

namespace UnitTests {
	[TestFixture]
	public class SecureMimeTests
	{
		SecureMimeContext smime;

		[TestFixtureSetUp]
		public void Setup ()
		{
			var dataDir = Path.Combine ("..", "..", "TestData", "smime");
			X509Certificate2Collection certs;
			string path;

			var store = new X509Store ("MimeKitUnitTests", StoreLocation.CurrentUser);
			store.Open (OpenFlags.ReadWrite);

			path = Path.Combine (dataDir, "certificate-authority.cert");
			store.Add (new X509Certificate2 (path));

			path = Path.Combine (dataDir, "smime.p12");
			certs = new X509Certificate2Collection ();
			certs.Import (path, "no.secret", X509KeyStorageFlags.UserKeySet);
			store.AddRange (certs);

			smime = new SecureMimeContext (store);
		}

		[TestFixtureTearDown]
		public void TearDown ()
		{
			smime.Dispose ();
		}

		[Test]
		public void TestSecureMimeSigning ()
		{
			var self = new MailboxAddress ("MimeKit UnitTests", "mimekit@example.com");

			var cleartext = new TextPart ("plain");
			cleartext.Text = "This is some cleartext that we'll end up signing...";

			var multipart = MultipartSigned.Create (smime, self, cleartext);
			Assert.AreEqual (2, multipart.Count, "The multipart/signed has an unexpected number of children.");

			var protocol = multipart.ContentType.Parameters["protocol"];
			Assert.AreEqual (smime.SignatureProtocol, protocol, "The multipart/signed protocol does not match.");

			Assert.IsInstanceOfType (typeof (TextPart), multipart[0], "The first child is not a text part.");
			Assert.IsInstanceOfType (typeof (ApplicationPkcs7Signature), multipart[1], "The second child is not a detached signature.");

			var signers = multipart.Verify ();
			Assert.AreEqual (1, signers.Count, "The signer info collection contains an unexpected number of signers.");
			foreach (var signer in signers) {
				try {
					// don't validate the signer against a CA since we're using a self-signed certificate
					signer.CheckSignature (true);
				} catch (Exception) {
					Assert.Fail ("Checking the signature of {0} failed.", signer);
				}
			}
		}

		[Test]
		public void TestSecureMimeEncryption ()
		{
			var self = new MailboxAddress ("MimeKit UnitTests", "mimekit@example.com");
			var recipients = new List<MailboxAddress> ();

			// encrypt to ourselves...
			recipients.Add (self);

			var cleartext = new TextPart ("plain");
			cleartext.Text = "This is some cleartext that we'll end up encrypting...";

			var encrypted = ApplicationPkcs7Mime.Encrypt (smime, recipients, cleartext);

			Assert.AreEqual (SecureMimeType.EnvelopedData, encrypted.SecureMimeType, "S/MIME type did not match.");

			var decrypted = encrypted.Decrypt (smime);

			Assert.IsInstanceOfType (typeof (TextPart), decrypted, "Decrypted part is not the expected type.");
			Assert.AreEqual (cleartext.Text, ((TextPart) decrypted).Text, "Decrypted content is not the same as the original.");
		}

		[Test]
		public void TestSecureMimeSignAndEncrypt ()
		{
			var self = new MailboxAddress ("MimeKit UnitTests", "mimekit@example.com");
			var recipients = new List<MailboxAddress> ();
			SignerInfoCollection signers;

			// encrypt to ourselves...
			recipients.Add (self);

			var cleartext = new TextPart ("plain");
			cleartext.Text = "This is some cleartext that we'll end up encrypting...";

			var encrypted = ApplicationPkcs7Mime.SignAndEncrypt (smime, self, recipients, cleartext);

			Assert.AreEqual (SecureMimeType.EnvelopedData, encrypted.SecureMimeType, "S/MIME type did not match.");

			var decrypted = encrypted.Decrypt (smime, out signers);

			Assert.IsInstanceOfType (typeof (TextPart), decrypted, "Decrypted part is not the expected type.");
			Assert.AreEqual (cleartext.Text, ((TextPart) decrypted).Text, "Decrypted content is not the same as the original.");

			Assert.AreEqual (1, signers.Count, "The signer info collection contains an unexpected number of signers.");
			foreach (var signer in signers) {
				try {
					// don't validate the signer against a CA since we're using a self-signed certificate
					signer.CheckSignature (true);
				} catch (Exception) {
					Assert.Fail ("Checking the signature of {0} failed.", signer);
				}
			}
		}

		[Test]
		public void TestSecureMimeImportExport ()
		{
			var self = new MailboxAddress ("MimeKit UnitTests", "mimekit@example.com");
			var mailboxes = new List<MailboxAddress> ();

			// we're going to export our public certificate so that we can email it to someone
			// so that they can then encrypt their emails to us.
			mailboxes.Add (self);

			var certsonly = smime.ExportKeys (mailboxes);

			Assert.IsInstanceOfType (typeof (ApplicationPkcs7Mime), "The exported mime part is not of the expected type.");

			var pkcs7mime = (ApplicationPkcs7Mime) certsonly;

			Assert.AreEqual (SecureMimeType.CertsOnly, pkcs7mime.SecureMimeType, "S/MIME type did not match.");

			var store = new X509Store ("ImportTest", StoreLocation.CurrentUser);
			store.Open (OpenFlags.ReadWrite);

			using (var import = new SecureMimeContext (store)) {
				try {
					pkcs7mime.Import (import);
				} catch {
					Assert.Fail ("Failed to import certificates.");
				}

				Assert.AreEqual (1, import.CertificateStore.Certificates.Count, "Unexpected number of imported certificates.");

				foreach (var cert in import.CertificateStore.Certificates) {
					Assert.IsFalse (cert.HasPrivateKey, "One or more of the certificates included the private key.");
				}
			}
		}
	}
}