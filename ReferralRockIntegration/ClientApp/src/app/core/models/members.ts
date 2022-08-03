export interface Member {
  id: string;
  displayName: string;
  firstName: string;
  lastName: string;
  email: string;
  phone: string;
  externalIdentifier: string;
  dateOfBirth?: any;
  addressLine1: string;
  addressLine2: string;
  city: string;
  countrySubdivision: string;
  country: string;
  postalCode: string;
  disabledFlag: boolean;
  customOverrideURL: string;
  payoutInfo: PayoutInfo;
  customOption1Name: string;
  customOption1Value: string;
  customText1Name: string;
  customText1Value: string;
  customText2Name: string;
  customText2Value: string;
  programId: string;
  programTitle: string;
  programName: string;
  referralUrl: string;
  referralCode: string;
  memberUrl: string;
  emailShares: number;
  socialShares: number;
  views: number;
  referrals: number;
  lastShare?: any;
  referralsApproved: number;
  referralsQualified: number;
  referralsPending: number;
  referralsApprovedAmount: number;
  rewardsPendingAmount: number;
  rewardsIssuedAmount: number;
  rewardAmountTotal: number;
  rewards: number;
  createDt: Date;
  utmSource: string;
  utmMedium: string;
  utmCampaign: string;
  browserReferrerUrl: string;
  lastViewIPAddress: string;
}

export interface PayoutInfo {
  payoutType: string;
  useDefaultValues: boolean;
  email: string;
}

export interface Members {
  offset: number;
  total: number;
  message?: any;
  members: Member[];
}
