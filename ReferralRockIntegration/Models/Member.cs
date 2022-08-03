using System.Text.Json.Serialization;

namespace ReferralRockIntegration.Models
{
    public class Member
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ExternalIdentifier { get; set; }
        public object DateOfBirth { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string CountrySubdivision { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public bool DisabledFlag { get; set; }
        public string CustomOverrideURL { get; set; }
        public PayoutInfo PayoutInfo { get; set; }
    }

    public class PayoutInfo
    {
        public string PayoutType { get; set; }
        public bool UseDefaultValues { get; set; }
        public string Email { get; set; }
    }

    public class Members
    {
        public int Offset { get; set; }
        public int Total { get; set; }
        public object Message { get; set; }

        [JsonPropertyName("members")]
        public List<Member> MemberList { get; set; }
    }
}
