using ReferralRockIntegration.Extensions;

namespace ReferralRockIntegration
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services
                .AddOptions(builder)
                .AddServices()
                .ConfigureHttpClient(builder.Configuration)
                .ConfigureCors()
                .ConfigureMemoryCache()
                .AddSpaStaticFiles()
                .AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseCors("local");
            app.UseStaticFiles();
            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";
            });
            app.MapControllers();

            await app.RunAsync();
        }

    }
}