using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Bookstore.Web.Startup
{
    public static class ConfigurationSetup
    {
        public static WebApplicationBuilder ConfigureConfiguration(this WebApplicationBuilder builder)
        {
            // Вклучи AWS само ако не си Development И environment е Production
            if (!builder.Environment.IsDevelopment() && builder.Environment.IsProduction())
            {
                builder.Configuration.AddSystemsManager("/BobsBookstore/");
            }

            return builder;
        }
    }
}
