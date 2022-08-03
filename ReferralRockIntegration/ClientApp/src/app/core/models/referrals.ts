export interface Referral {
  id: string;
  displayName: string;
  firstName: string;
  lastName: string;
  fullName: string;
  email: string;
  externalIdentifier: string;
  phoneNumber: string;
  amount: number;
  amountFormatted: string;
  preferredContact: string;
  createDate: Date;
  updateDate: Date;
  source: string;
  programId: string;
  programName: string;
  programTitle: string;
  referringMemberId: string;
  referringMemberName: string;
  memberEmail: string;
  memberReferralCode: string;
  memberExternalIdentifier: string;
  approvedDate: Date;
  qualifiedDate: Date;
  status: string;
  companyName: string;
  note: string;
  publicNote: string;
  customOption1Name: string;
  customOption2Name: string;
  customText1Name: string;
  customText2Name: string;
  customText3Name: string;
  customOption1Value: string;
  customOption2Value: string;
  customText1Value: string;
  customText2Value: string;
  customText3Value: string;
  conversionNote: string;
  conversionIPAddress: string;
  utmSource: string;
  utmMedium: string;
  utmCampaign: string;
  browserReferrerUrl: string;
  IPAddressSource: string;
}

export interface Referrals {
  offset: number;
  total: number;
  message: string;
  referrals: Referral[];
}
