using ApiProject.Application.Interfaces.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace ApiProject.Mapper
{
    public static class Registration
    {
        public static void AddMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }
    }
}
