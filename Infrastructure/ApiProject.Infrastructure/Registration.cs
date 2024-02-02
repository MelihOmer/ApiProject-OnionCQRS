using ApiProject.Application.Interfaces.RedisCache;
using ApiProject.Application.Interfaces.Tokens;
using ApiProject.Infrastructure.RedisCache;
using ApiProject.Infrastructure.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ApiProject.Infrastructure
{
    public static class Registration
    {
        public  static void AddInfrastructure(this IServiceCollection services,IConfiguration config)
        {
            services.Configure<TokenSettings>(config.GetSection("JWT"));
            services.AddTransient<ITokenService,TokenService>();

            services.Configure<RedisCacheSettings>(config.GetSection("RedisCacheSettings"));
            services.AddTransient<IRedisCacheService,RedisCacheService>();

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme,opt =>
            {
                opt.SaveToken = true;
                opt.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:SecretKey"])),
                    ValidateLifetime = false,
                    ValidIssuer = config["JWT:Issuer"],
                    ValidAudience = config["JWT:Audience"],
                    ClockSkew = TimeSpan.Zero
                };
            });
            services.AddStackExchangeRedisCache(opt =>
            {
                opt.Configuration = config["RedisCacheSettings : ConnectionString"];
                opt.InstanceName = config["RedisCacheSettings : InstanceName"];
            });
        }
    }
}
