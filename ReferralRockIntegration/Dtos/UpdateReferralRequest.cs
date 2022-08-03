namespace ReferralRockIntegration.Dtos
{
    public class UpdateReferralRequest
    {
        public UpdateReferralRequest()
        {
            Query = new Query();
            Referral = new Referral();
        }
        public Query Query { get; set; }
        public Referral Referral { get; set; }
    }

    public class FuzzyInfo
    {
        public string Identifier { get; set; }
    }

    public class PrimaryInfo
    {
        public string ReferralId { get; set; }
    }

    public class Query
    {
        public Query()
        {
            PrimaryInfo = new PrimaryInfo();
            SecondaryInfo = new SecondaryInfo();
            TertiaryInfo = new TertiaryInfo();
            FuzzyInfo = new FuzzyInfo();
        }

        public PrimaryInfo PrimaryInfo { get; set; }
        public SecondaryInfo SecondaryInfo { get; set; }
        public TertiaryInfo TertiaryInfo { get; set; }
        public FuzzyInfo FuzzyInfo { get; set; }
    }

    public class Referral
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PreferredContact { get; set; }
        public string ExternalIdentifier { get; set; }
        public decimal Amount { get; set; }
        public string CompanyName { get; set; }
        public string Note { get; set; }
        public string PublicNote { get; set; }
        public string CustomOption1Name { get; set; }
        public string CustomOption2Name { get; set; }
        public string CustomText1Name { get; set; }
        public string CustomText2Name { get; set; }
        public string CustomText3Name { get; set; }
        public string CustomOption1Value { get; set; }
        public string CustomOption2Value { get; set; }
        public string CustomText1Value { get; set; }
        public string CustomText2Value { get; set; }
        public string CustomText3Value { get; set; }
        public string Status { get; set; }
    }

    public class SecondaryInfo
    {
        public string ExternalIdentifier { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class TertiaryInfo
    {
        public string ProgramId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramTitle { get; set; }
    }
}
