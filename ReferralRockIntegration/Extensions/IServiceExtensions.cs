using Microsoft.Extensions.Caching.Memory;
using ReferralRockIntegration.Options;
using System.Net.Http.Headers;

namespace ReferralRockIntegration.Extensions
{
    public static class IServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {


            return services;
        }

        public static IServiceCollection AddOptions(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services
                .AddOptions()
                .Configure<HttpOptions>(builder.Configuration.GetSection(nameof(HttpOptions)))
                .Configure<LoggerOptions>(builder.Configuration.GetSection(LoggerOptions.Logger));

            return services;
        }

        public static IServiceCollection ConfigureHttpClient(this IServiceCollection services, ConfigurationManager config)
        {
            services.AddHttpClient(
                "ReferralRock",
                HttpClient =>
                {
                    HttpClient.BaseAddress = config["HttpOptions:Host"].ToUri();
                    HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(config["HttpOptions:AuthScheme"], config["HttpOptions:BasicAuthKey"]);
                });

            return services;
        }

        public static IServiceCollection ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(
                    name: "local",
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod());
            });

            return services;
        }

        public static IServiceCollection ConfigureMemoryCache(this IServiceCollection services)
        {
            var cacheOptions = new MemoryCacheOptions
            {
                SizeLimit = 2048,
                CompactionPercentage = 0.25,
                ExpirationScanFrequency = TimeSpan.FromMilliseconds(500)
            };
            var memoryCache = new MemoryCache(cacheOptions);
            services.AddSingleton<IMemoryCache>(memoryCache);

            return services;
        }

        public static IServiceCollection AddSpaStaticFiles(this IServiceCollection services)
        {
            services.AddSpaStaticFiles(config =>
            {
                config.RootPath = "ClientApp/dist";
            });

            return services;
        }
    }
}
