namespace ReferralRockIntegration.Options
{
    public class HttpOptions
    {
        public const string Http = "HttpOptions";

        public string Host { get; set; }

        public string BasicAuthKey { get; set; }
    }
}
