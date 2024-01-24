using ApiProject.Application.Interfaces.Repositories;
using ApiProject.Persistence.Context;
using ApiProject.Persistence.Repositories;
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
        }
    }
}
