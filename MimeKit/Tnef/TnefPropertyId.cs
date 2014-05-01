﻿//
// TnefPropertyId.cs
//
// Author: Jeffrey Stedfast <jeff@xamarin.com>
//
// Copyright (c) 2014 Xamarin Inc. (www.xamarin.com)
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

namespace MimeKit.Tnef {
	enum TnefPropertyId : short {
		AbDefaultDir                             = 0x3D06,
		AbDefaultPab                             = 0x3D07,
		AbProviderId                             = 0x3615,
		AbProviders                              = 0x3D01,
		AbSearchPath                             = 0x3D05,
		AbSearchPathUpdate                       = 0x3D11,
		Access                                   = 0x0FF4,
		AccessLevel                              = 0x0FF7,
		Account                                  = 0x3A00,
		AcknowledgementMode                      = 0x0001,
		Addrtype                                 = 0x3002,
		AlternateRecipient                       = 0x3A01,
		AlternateRecipientAllowed                = 0x0002,
		Anr                                      = 0x360C,
		Assistant                                = 0x3A30,
		AssistantTelephoneNumber                 = 0x3A2E,
		AssocContentCount                        = 0x3617,
		AttachAdditionalInfo                     = 0x370F,
		AttachContentBase                        = 0x3711,
		AttachContentId                          = 0x3712,
		AttachContentLocation                    = 0x3713,
		AttachData                               = 0x3701,
		AttachDisposition                        = 0x3716,
		AttachEncoding                           = 0x3702,
		AttachExtension                          = 0x3703,
		AttachFilename                           = 0x3704,
		AttachFlags                              = 0x3714,
		AttachLongFilename                       = 0x3707,
		AttachLongPathname                       = 0x370D,
		AttachmentX400Parameters                 = 0x3700,
		AttachMethod                             = 0x3705,
		AttachMimeSequence                       = 0x3710,
		AttachMimeTag                            = 0x370E,
		AttachNetscapeMacInfo                    = 0x3715,
		AttachNum                                = 0x0E21,
		AttachPathname                           = 0x3708,
		AttachRendering                          = 0x3709,
		AttachSize                               = 0x0E20,
		AttachTag                                = 0x370A,
		AttachTransportName                      = 0x370C,
		AuthorizingUsers                         = 0x0003,
		AutoForwarded                            = 0x0005,
		AutoForwardingComment                    = 0x0004,
		AutoResponseSuppress                     = 0x3FDF,
		BeeperTelephoneNumber                    = 0x3A21,
		Birthday                                 = 0x3A42,
		Body                                     = 0x1000,
		BodyContentId                            = 0x1015,
		BodyContentLocation                      = 0x1014,
		BodyCrc                                  = 0x0E1C,
		BodyHtml                                 = 0x1013,
		Business2TelephoneNumber                 = 0x3A1B,
		BusinessAddressCity                      = 0x3A27,
		BusinessAddressCountry                   = 0x3A26,
		BusinessAddressPostalCode                = 0x3A2A,
		BusinessAddressPostOfficeBox             = 0x3A2B,
		BusinessAddressStateOrProvince           = 0x3A28,
		BusinessAddressStreet                    = 0x3A29,
		BusinessFaxNumber                        = 0x3A24,
		BusinessHomePage                         = 0x3A51,
		CallbackTelephoneNumber                  = 0x3A02,
		CarTelephoneNumber                       = 0x3A1E,
		CellularTelephoneNumber                  = 0x3A1C,
		ChildrensNames                           = 0x3A58,
		ClientSubmitTime                         = 0x0039,
		Comment                                  = 0x3004,
		CommonViewsEntryId                       = 0x35E6,
		CompanyMainPhoneNumber                   = 0x3A57,
		CompanyName                              = 0x3A16,
		ComputerNetworkName                      = 0x3A49,
		ContactAddrtypes                         = 0x3A54,
		ContactDefaultAddressIndex               = 0x3A55,
		ContactEmailAddresses                    = 0x3A56,
		ContactEntryIds                          = 0x3A53,
		ContactVersion                           = 0x3A52,
		ContainerClass                           = 0x3613,
		ContainerContents                        = 0x360F,
		ContainerFlags                           = 0x3600,
		ContainerHierarchy                       = 0x360E,
		ContainerModifyVersion                   = 0x3614,
		ContentConfidentialityAlgorithmId        = 0x0006,
		ContentCorrelator                        = 0x0007,
		ContentCount                             = 0x3602,
		ContentIdentifier                        = 0x0008,
		ContentIntegrityCheck                    = 0x0C00,
		ContentLength                            = 0x0009,
		ContentReturnRequested                   = 0x000A,
		ContentsSortOrder                        = 0x360D,
		ContentUnread                            = 0x3603,
		ControlFlags                             = 0x3F00,
		ControlId                                = 0x3F07,
		ControlStructure                         = 0x3F01,
		ControlType                              = 0x3F02,
		ConversationIndex                        = 0x0071,
		ConversationKey                          = 0x000B,
		ConversationTopic                        = 0x0070,
		ConversionEits                           = 0x000C,
		ConversionProhibited                     = 0x3A03,
		ConversionWithLossProhibited             = 0x000D,
		ConvertedEits                            = 0x000E,
		Correlate                                = 0x0E0C,
		CorrelateMtsid                           = 0x0E0D,
		Country                                  = 0x3A26,
		CreateTemplates                          = 0x3604,
		CreationTime                             = 0x3007,
		CreationVersion                          = 0x0E19,
		CurrentVersion                           = 0x0E00,
		CustomerId                               = 0x3A4A,
		DefaultProfile                           = 0x3D04,
		DefaultStore                             = 0x3400,
		DefaultViewEntryId                       = 0x3616,
		DefCreateDl                              = 0x3611,
		DefCreateMailuser                        = 0x3612,
		DeferredDeliveryTime                     = 0x000F,
		Delegation                               = 0x007E,
		DeleteAfterSubmit                        = 0x0E01,
		DeliverTime                              = 0x0010,
		DeliveryPoint                            = 0x0C07,
		Deltax                                   = 0x3F03,
		Deltay                                   = 0x3F04,
		DepartmentName                           = 0x3A18,
		Depth                                    = 0x3005,
		DetailsTable                             = 0x3605,
		DiscardReason                            = 0x0011,
		DiscloseRecipients                       = 0x3A04,
		DisclosureOfRecipients                   = 0x0012,
		DiscreteValues                           = 0x0E0E,
		DiscVal                                  = 0x004A,
		DisplayBcc                               = 0x0E02,
		DisplayCc                                = 0x0E03,
		DisplayName                              = 0x3001,
		DisplayNamePrefix                        = 0x3A45,
		DisplayTo                                = 0x0E04,
		DisplayType                              = 0x3900,
		DlExpansionHistory                       = 0x0013,
		DlExpansionProhibited                    = 0x0014,
		EmailAddress                             = 0x3003,
		EndDate                                  = 0x0061,
		EntryId                                  = 0x0FFF,
		ExpandBeginTime                          = 0x3618,
		ExpandedBeginTime                        = 0x361A,
		ExpandedEndTime                          = 0x361B,
		ExpandEndTime                            = 0x3619,
		ExpiryTime                               = 0x0015,
		ExplicitConversion                       = 0x0C01,
		FilteringHooks                           = 0x3D08,
		FinderEntryId                            = 0x35E7,
		FolderAssociatedContents                 = 0x3610,
		FolderType                               = 0x3601,
		FormCategory                             = 0x3304,
		FormCategorySub                          = 0x3305,
		FormClsid                                = 0x3302,
		FormContactName                          = 0x3303,
		FormDesignerGuid                         = 0x3309,
		FormDesignerName                         = 0x3308,
		FormHidden                               = 0x3307,
		FormHostMap                              = 0x3306,
		FormMessageBehavior                      = 0x330A,
		FormVersion                              = 0x3301,
		FtpSite                                  = 0x3A4C,
		Gender                                   = 0x3A4D,
		Generation                               = 0x3A05,
		GivenName                                = 0x3A06,
		GovernmentIdNumber                       = 0x3A07,
		Hasattach                                = 0x0E1B,
		HeaderFolderEntryId                      = 0x3E0A,
		Hobbies                                  = 0x3A43,
		Home2TelephoneNumber                     = 0x3A2F,
		HomeAddressCity                          = 0x3A59,
		HomeAddressCountry                       = 0x3A5A,
		HomeAddressPostalCode                    = 0x3A5B,
		HomeAddressPostOfficeBox                 = 0x3A5E,
		HomeAddressStateOrProvince               = 0x3A5C,
		HomeAddressStreet                        = 0x3A5D,
		HomeFaxNumber                            = 0x3A25,
		HomeTelephoneNumber                      = 0x3A09,
		Icon                                     = 0x0FFD,
		IdentityDisplay                          = 0x3E00,
		IdentityEntryId                          = 0x3E01,
		IdentitySearchKey                        = 0x3E05,
		ImplicitConversionProhibited             = 0x0016,
		Importance                               = 0x0017,
		IncompleteCopy                           = 0x0035,
		INetMailOverrideCharset                  = 0x5903,
		INetMailOverrideFormat                   = 0x5902,
		InitialDetailsPane                       = 0x3F08,
		Initials                                 = 0x3A0A,
		InReplyToId                              = 0x1042,
		InstanceKey                              = 0x0FF6,
		InternetApproved                         = 0x1030,
		InternetArticleNumber                    = 0x0E23,
		InternetControl                          = 0x1031,
		InternetCPID                             = 0x3FDE,
		InternetDistribution                     = 0x1032,
		InternetFollowupTo                       = 0x1033,
		InternetLines                            = 0x1034,
		InternetMessageId                        = 0x1035,
		InternetNewsgroups                       = 0x1036,
		InternetNntpPath                         = 0x1038,
		InternetOrganization                     = 0x1037,
		InternetPrecedence                       = 0x1041,
		InternetReferences                       = 0x1039,
		IpmId                                    = 0x0018,
		IpmOutboxEntryId                         = 0x35E2,
		IpmOutboxSearchKey                       = 0x3411,
		IpmReturnRequested                       = 0x0C02,
		IpmSentmailEntryId                       = 0x35E4,
		IpmSentmailSearchKey                     = 0x3413,
		IpmSubtreeEntryId                        = 0x35E0,
		IpmSubtreeSearchKey                      = 0x3410,
		IpmWastebasketEntryId                    = 0x35E3,
		IpmWastebasketSearchKey                  = 0x3412,
		IsdnNumber                               = 0x3A2D,
		Keyword                                  = 0x3A0B,
		Language                                 = 0x3A0C,
		Languages                                = 0x002F,
		LastModificationTime                     = 0x3008,
		LatestDeliveryTime                       = 0x0019,
		ListHelp                                 = 0x1043,
		ListSubscribe                            = 0x1044,
		ListUnsubscribe                          = 0x1045,
		Locality                                 = 0x3A27,
		LocallyDelivered                         = 0x6745,
		Location                                 = 0x3A0D,
		LockBranchId                             = 0x3800,
		LockDepth                                = 0x3808,
		LockEnlistmentContext                    = 0x3804,
		LockExpiryTime                           = 0x380A,
		LockPersistent                           = 0x3807,
		LockResourceDid                          = 0x3802,
		LockResourceFid                          = 0x3801,
		LockResourceMid                          = 0x3803,
		LockScope                                = 0x3806,
		LockTimeout                              = 0x3809,
		LockType                                 = 0x3805,
		MailPermission                           = 0x3A0E,
		ManagerName                              = 0x3A4E,
		MappingSignature                         = 0x0FF8,
		MdbProvider                              = 0x3414,
		MessageAttachments                       = 0x0E13,
		MessageCcMe                              = 0x0058,
		MessageClass                             = 0x001A,
		MessageCodepage                          = 0x3FFD,
		MessageDeliveryId                        = 0x001B,
		MessageDeliveryTime                      = 0x0E06,
		MessageDownloadTime                      = 0x0E18,
		MessageFlags                             = 0x0E07,
		MessageRecipients                        = 0x0E12,
		MessageRecipMe                           = 0x0059,
		MessageSecurityLabel                     = 0x001E,
		MessageSize                              = 0x0E08,
		MessageSubmissionId                      = 0x0047,
		MessageToken                             = 0x0C03,
		MessageToMe                              = 0x0057,
		MhsCommonName                            = 0x3A0F,
		MiddleName                               = 0x3A44,
		MiniIcon                                 = 0x0FFC,
		MobileTelephoneNumber                    = 0x3A1C,
		ModifyVersion                            = 0x0E1A,
		MsgStatus                                = 0x0E17,
		NdrDiagCode                              = 0x0C05,
		NdrReasonCode                            = 0x0C04,
		NdrStatusCode                            = 0x0C20,
		NewsgroupName                            = 0x0E24,
		Nickname                                 = 0x3A4F,
		NntpXref                                 = 0x1040,
		NonReceiptNotificationRequested          = 0x0C06,
		NonReceiptReason                         = 0x003E,
		NormalizedSubject                        = 0x0E1D,
		NtSecurityDescriptor                     = 0x0E27,
		Null                                     = 0x0000,
		ObjectType                               = 0x0FFE,
		ObsoletedIpms                            = 0x001F,
		Office2TelephoneNumber                   = 0x3A1B,
		OfficeLocation                           = 0x3A19,
		OfficeTelephoneNumber                    = 0x3A08,
		OofReplyType                             = 0x4080,
		OrganizationalIdNumber                   = 0x3A10,
		OrigEntryId                              = 0x300F,
		OriginalAuthorAddrtype                   = 0x0079,
		OriginalAuthorEmailAddress               = 0x007A,
		OriginalAuthorEntryId                    = 0x004C,
		OriginalAuthorName                       = 0x004D,
		OriginalAuthorSearchKey                  = 0x0056,
		OriginalDeliveryTime                     = 0x0055,
		OriginalDisplayBcc                       = 0x0072,
		OriginalDisplayCc                        = 0x0073,
		OriginalDisplayName                      = 0x3A13,
		OriginalDisplayTo                        = 0x0074,
		OriginalEits                             = 0x0021,
		OriginalEntryId                          = 0x3A12,
		OriginallyIntendedRecipAddrtype          = 0x007B,
		OriginallyIntendedRecipEmailAddress      = 0x007C,
		OriginallyIntendedRecipEntryId           = 0x1012,
		OriginallyIntendedRecipientName          = 0x0020,
		OriginalSearchKey                        = 0x3A14,
		OriginalSenderAddrtype                   = 0x0066,
		OriginalSenderEmailAddress               = 0x0067,
		OriginalSenderEntryId                    = 0x005B,
		OriginalSenderName                       = 0x005A,
		OriginalSenderSearchKey                  = 0x005C,
		OriginalSensitivity                      = 0x002E,
		OriginalSentRepresentingAddrtype         = 0x0068,
		OriginalSentRepresentingEmailAddress     = 0x0069,
		OriginalSentRepresentingEntryId          = 0x005E,
		OriginalSentRepresentingName             = 0x005D,
		OriginalSentRepresentingSearchKey        = 0x005F,
		OriginalSubject                          = 0x0049,
		OriginalSubmitTime                       = 0x004E,
		OriginatingMtaCertificate                = 0x0E25,
		OriginatorAndDlExpansionHistory          = 0x1002,
		OriginatorCertificate                    = 0x0022,
		OriginatorDeliveryReportRequested        = 0x0023,
		OriginatorNonDeliveryReportRequested     = 0x0C08,
		OriginatorRequestedAlternateRecipient    = 0x0C09,
		OriginatorReturnAddress                  = 0x0024,
		OriginCheck                              = 0x0027,
		OrigMessageClass                         = 0x004B,
		OtherAddressCity                         = 0x3A5F,
		OtherAddressCountry                      = 0x3A60,
		OtherAddressPostalCode                   = 0x3A61,
		OtherAddressPostOfficeBox                = 0x3A64,
		OtherAddressStateOrProvince              = 0x3A62,
		OtherAddressStreet                       = 0x3A63,
		OtherTelephoneNumber                     = 0x3A1F,
		OwnerApptId                              = 0x0062,
		OwnStoreEntryId                          = 0x3E06,
		PagerTelephoneNumber                     = 0x3A21,
		ParentDisplay                            = 0x0E05,
		ParentEntryId                            = 0x0E09,
		ParentKey                                = 0x0025,
		PersonalHomePage                         = 0x3A50,
		PhysicalDeliveryBureauFaxDelivery        = 0x0C0A,
		PhysicalDeliveryMode                     = 0x0C0B,
		PhysicalDeliveryReportRequest            = 0x0C0C,
		PhysicalForwardingAddress                = 0x0C0D,
		PhysicalForwardingAddressRequested       = 0x0C0E,
		PhysicalForwardingProhibited             = 0x0C0F,
		PhysicalRenditionAttributes              = 0x0C10,
		PostalAddress                            = 0x3A15,
		PostalCode                               = 0x3A2A,
		PostFolderEntries                        = 0x103B,
		PostFolderNames                          = 0x103C,
		PostOfficeBox                            = 0x3A2B,
		PostReplyDenied                          = 0x103F,
		PostReplyFolderEntries                   = 0x103D,
		PostReplyFolderNames                     = 0x103E,
		PreferredByName                          = 0x3A47,
		Preprocess                               = 0x0E22,
		PrimaryCapability                        = 0x3904,
		PrimaryFaxNumber                         = 0x3A23,
		PrimaryTelephoneNumber                   = 0x3A1A,
		Priority                                 = 0x0026,
		Profession                               = 0x3A46,
		ProfileName                              = 0x3D12,
		ProofOfDelivery                          = 0x0C11,
		ProofOfDeliveryRequested                 = 0x0C12,
		ProofOfSubmission                        = 0x0E26,
		ProofOfSubmissionRequested               = 0x0028,
		PropIdSecureMax                          = 0x67FF,
		PropIdSecureMin                          = 0x67F0,
		ProviderDisplay                          = 0x3006,
		ProviderDllName                          = 0x300A,
		ProviderOrdinal                          = 0x300D,
		ProviderSubmitTime                       = 0x0048,
		ProviderUid                              = 0x300C,
		Puid                                     = 0x300E,
		RadioTelephoneNumber                     = 0x3A1D,
		RcvdRepresentingAddrtype                 = 0x0077,
		RcvdRepresentingEmailAddress             = 0x0078,
		RcvdRepresentingEntryId                  = 0x0043,
		RcvdRepresentingName                     = 0x0044,
		RcvdRepresentingSearchKey                = 0x0052,
		ReadReceiptEntryId                       = 0x0046,
		ReadReceiptRequested                     = 0x0029,
		ReadReceiptSearchKey                     = 0x0053,
		ReceiptTime                              = 0x002A,
		ReceivedByAddrtype                       = 0x0075,
		ReceivedByEmailAddress                   = 0x0076,
		ReceivedByEntryId                        = 0x003F,
		ReceivedByName                           = 0x0040,
		ReceivedBySearchKey                      = 0x0051,
		ReceiveFolderSettings                    = 0x3415,
		RecipientCertificate                     = 0x0C13,
		RecipientNumberForAdvice                 = 0x0C14,
		RecipientReassignmentProhibited          = 0x002B,
		RecipientStatus                          = 0x0E15,
		RecipientType                            = 0x0C15,
		RecordKey                                = 0x0FF9,
		RedirectionHistory                       = 0x002C,
		ReferredByName                           = 0x3A47,
		RegisteredMailType                       = 0x0C16,
		RelatedIpms                              = 0x002D,
		RemoteProgress                           = 0x3E0B,
		RemoteProgressText                       = 0x3E0C,
		RemoteValidateOk                         = 0x3E0D,
		RenderingPosition                        = 0x370B,
		ReplyRecipientEntries                    = 0x004F,
		ReplyRecipientNames                      = 0x0050,
		ReplyRequested                           = 0x0C17,
		ReplyTime                                = 0x0030,
		ReportEntryId                            = 0x0045,
		ReportingDlName                          = 0x1003,
		ReportingMtaCertificate                  = 0x1004,
		ReportName                               = 0x003A,
		ReportSearchKey                          = 0x0054,
		ReportTag                                = 0x0031,
		ReportText                               = 0x1001,
		ReportTime                               = 0x0032,
		RequestedDeliveryMethod                  = 0x0C18,
		ResourceFlags                            = 0x3009,
		ResourceMethods                          = 0x3E02,
		ResourcePath                             = 0x3E07,
		ResourceType                             = 0x3E03,
		ResponseRequested                        = 0x0063,
		Responsibility                           = 0x0E0F,
		ReturnedIpm                              = 0x0033,
		Rowid                                    = 0x3000,
		RowType                                  = 0x0FF5,
		RtfCompressed                            = 0x1009,
		RtfInSync                                = 0x0E1F,
		RtfSyncBodyCount                         = 0x1007,
		RtfSyncBodyCrc                           = 0x1006,
		RtfSyncBodyTag                           = 0x1008,
		RtfSyncPrefixCount                       = 0x1010,
		RtfSyncTrailingCount                     = 0x1011,
		Search                                   = 0x3607,
		SearchKey                                = 0x300B,
		Security                                 = 0x0034,
		Selectable                               = 0x3609,
		SenderAddrtype                           = 0x0C1E,
		SenderEmailAddress                       = 0x0C1F,
		SenderEntryId                            = 0x0C19,
		SenderName                               = 0x0C1A,
		SenderSearchKey                          = 0x0C1D,
		SendInternetEncoding                     = 0x3A71,
		SendRecallReport                         = 0x6803,
		SendRichInfo                             = 0x3A40,
		Sensitivity                              = 0x0036,
		SentmailEntryId                          = 0x0E0A,
		SentRepresentingAddrtype                 = 0x0064,
		SentRepresentingEmailAddress             = 0x0065,
		SentRepresentingEntryId                  = 0x0041,
		SentRepresentingName                     = 0x0042,
		SentRepresentingSearchKey                = 0x003B,
		ServiceDeleteFiles                       = 0x3D10,
		ServiceDllName                           = 0x3D0A,
		ServiceEntryName                         = 0x3D0B,
		ServiceExtraUids                         = 0x3D0D,
		ServiceName                              = 0x3D09,
		Services                                 = 0x3D0E,
		ServiceSupportFiles                      = 0x3D0F,
		ServiceUid                               = 0x3D0C,
		SevenBitDisplayName                      = 0x39FF,
		SmtpAddress                              = 0x39FE,
		SpoolerStatus                            = 0x0E10,
		SpouseName                               = 0x3A48,
		StartDate                                = 0x0060,
		StateOrProvince                          = 0x3A28,
		Status                                   = 0x360B,
		StatusCode                               = 0x3E04,
		StatusString                             = 0x3E08,
		StoreEntryId                             = 0x0FFB,
		StoreProviders                           = 0x3D00,
		StoreRecordKey                           = 0x0FFA,
		StoreState                               = 0x340E,
		StoreSupportMask                         = 0x340D,
		StreetAddress                            = 0x3A29,
		Subfolders                               = 0x360A,
		Subject                                  = 0x0037,
		SubjectIpm                               = 0x0038,
		SubjectPrefix                            = 0x003D,
		SubmitFlags                              = 0x0E14,
		Supersedes                               = 0x103A,
		SupplementaryInfo                        = 0x0C1B,
		Surname                                  = 0x3A11,
		TelexNumber                              = 0x3A2C,
		Templateid                               = 0x3902,
		Title                                    = 0x3A17,
		TnefCorrelationKey                       = 0x007F,
		TransmitableDisplayName                  = 0x3A20,
		TransportKey                             = 0x0E16,
		TransportMessageHeaders                  = 0x007D,
		TransportProviders                       = 0x3D02,
		TransportStatus                          = 0x0E11,
		TtytddPhoneNumber                        = 0x3A4B,
		TypeOfMtsUser                            = 0x0C1C,
		UserCertificate                          = 0x3A22,
		UserX509Certificate                      = 0x3A70,
		ValidFolderMask                          = 0x35DF,
		ViewsEntryId                             = 0x35E5,
		WeddingAnniversary                       = 0x3A41,
		X400ContentType                          = 0x003C,
		X400DeferredDeliveryCancel               = 0x3E09,
		Xpos                                     = 0x3F05,
		Ypos                                     = 0x3F06,
	}
}
