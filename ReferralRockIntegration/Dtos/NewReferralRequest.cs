namespace ReferralRockIntegration.Dtos
{
    public class NewReferralRequest
    {
        public string ReferralCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Amount { get; set; }
        public bool IsApproved { get; set; }
    }
}
