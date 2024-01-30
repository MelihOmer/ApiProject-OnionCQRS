using ApiProject.Application.Bases;
using ApiProject.Application.Features.Auth.Rules;
using ApiProject.Application.Interfaces.AutoMapper;
using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace ApiProject.Application.Features.Auth.Command.Register
{
    public class RegisterCommandHandler : BaseHandler,IRequestHandler<RegisterCommandRequest, Unit>
    {
        private readonly AuthRules authRules;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;
        private static string defaultRole = "user";

        public RegisterCommandHandler(AuthRules authRules,UserManager<User> userManager,RoleManager<Role> roleManager,IMapper mapper,IUnitOfWork unitOfWork,IHttpContextAccessor httpContext):base(mapper,unitOfWork,httpContext)
        {
            this.authRules = authRules;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public async Task<Unit> Handle(RegisterCommandRequest request, CancellationToken cancellationToken)
        {
            await authRules.UserShouldNotBeExist(await userManager.FindByEmailAsync(request.Email));

            User user = mapper.Map<User, RegisterCommandRequest>(request);
            user.UserName = request.Email;
            user.SecurityStamp = Guid.NewGuid().ToString();

            IdentityResult result = await userManager.CreateAsync(user,request.Password);
            if (result.Succeeded)
            {
                if (!await roleManager.RoleExistsAsync(defaultRole))
                    await roleManager.CreateAsync(new Role
                    {
                        Id=Guid.NewGuid(),
                        Name= defaultRole,
                        NormalizedName= defaultRole.ToUpper(),
                        ConcurrencyStamp=Guid.NewGuid().ToString()
                    });
                await userManager.AddToRoleAsync(user, defaultRole);
            }
            return Unit.Value;
        }
    }
}
