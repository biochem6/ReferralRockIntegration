namespace ReferralRockIntegration.Dtos
{
    public class EditReferralRequest
    {
        public string ReferralId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Amount { get; set; }
    }
}
