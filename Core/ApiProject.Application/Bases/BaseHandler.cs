using ApiProject.Application.Interfaces.AutoMapper;
using ApiProject.Application.Interfaces.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace ApiProject.Application.Bases
{
    public class BaseHandler
    {
        protected readonly IMapper mapper;
        protected readonly IUnitOfWork unitOfWork;
        protected readonly IHttpContextAccessor httpContext;
        protected readonly string userId;

        public BaseHandler(IMapper mapper,IUnitOfWork unitOfWork,IHttpContextAccessor httpContext)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.httpContext = httpContext;
            userId = httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
