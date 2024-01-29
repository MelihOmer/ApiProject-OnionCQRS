using ApiProject.Infrastructure.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiProject.Infrastructure
{
    public static class Registration
    {
        public  static void AddInfrastructure(this IServiceCollection services,IConfiguration config)
        {
            services.Configure<TokenSettings>(config.GetSection("JWT"));
        }
    }
}
