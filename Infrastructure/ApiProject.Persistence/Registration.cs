using ApiProject.Application.Interfaces.Repositories;
using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
using ApiProject.Persistence.Context;
using ApiProject.Persistence.Repositories;
using ApiProject.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiProject.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
            opt.UseSqlServer(configuration
            .GetConnectionString("DefaultConntectionString")));

            //Repository Registration
            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            services.AddScoped<IUnitOfWork,UnitOfWork>();

            services.AddIdentityCore<User>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 4;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireDigit = false;
                opt.SignIn.RequireConfirmedEmail = false;
            })
                .AddRoles<Role>()
                .AddEntityFrameworkStores<AppDbContext>();
        }
    }
}
