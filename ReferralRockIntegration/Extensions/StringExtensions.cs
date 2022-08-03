namespace ReferralRockIntegration.Extensions
{
    public static class StringExtensions
    {
        public static Uri ToUri(this string source)
            => new(source);
    }
}
