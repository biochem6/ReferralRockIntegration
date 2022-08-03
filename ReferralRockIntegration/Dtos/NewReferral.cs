namespace ReferralRockIntegration.Dtos
{
    public class NewReferral
    {
        public string? ReferralCode { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PreferredContact { get; set; }
        public string? ExternalIdentifier { get; set; }
        public double Amount { get; set; }
        public string? CompanyName { get; set; }
        public string? Note { get; set; }
        public string? PublicNote { get; set; }
        public string? CustomOption1Name { get; set; }
        public string? CustomOption2Name { get; set; }
        public string? CustomText1Name { get; set; }
        public string? CustomText2Name { get; set; }
        public string? CustomText3Name { get; set; }
        public string? CustomOption1Value { get; set; }
        public string? CustomOption2Value { get; set; }
        public string? CustomText1Value { get; set; }
        public string? CustomText2Value { get; set; }
        public string? CustomText3Value { get; set; }
        public string? Status { get; set; }

        public NewReferral(
            string referralCode,
            string firstName = null,
            string lastName = null,
            string email = null,
            string phoneNumber = null,
            string preferredContact = null,
            string externalIdentifier = null,
            double amount = 0,
            string companyName = null,
            string note = null,
            string publicNote = null,
            string customOption1Name = null,
            string customOption2Name = null,
            string customText1Name = null,
            string customText2Name = null,
            string customText3Name = null,
            string customOption1Value = null,
            string customOption2Value = null,
            string customText1Value = null,
            string customText2Value = null,
            string customText3Value = null,
            string status = null)
        {
            ReferralCode = referralCode;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            PreferredContact = preferredContact;
            ExternalIdentifier = externalIdentifier;
            Amount = amount;
            CompanyName = companyName;
            Note = note;
            PublicNote = publicNote;
            CustomOption1Name = customOption1Name;
            CustomOption2Name = customOption2Name;
            CustomText1Name = customText1Name;
            CustomText2Name = customText2Name;
            CustomText3Name = customText3Name;
            CustomOption1Value = customOption1Value;
            CustomOption2Value = customOption2Value;
            CustomText1Value = customText1Value;
            CustomText2Value = customText2Value;
            CustomText3Value = customText3Value;
            Status = status;
        }
    }
}
