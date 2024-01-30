using ApiProject.Application.Bases;
using ApiProject.Application.Features.Auth.Exceptions;
using ApiProject.Domain.Entities;

namespace ApiProject.Application.Features.Auth.Rules
{
    public class AuthRules : BaseRules
    {
        public Task UserShouldNotBeExist(User? user)
        {
            if (user is not null) throw new UserAlreadyExistException();
            return Task.CompletedTask;
        }
    }
}
