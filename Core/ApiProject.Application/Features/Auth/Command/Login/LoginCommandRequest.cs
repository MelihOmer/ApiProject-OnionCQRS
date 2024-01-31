using MediatR;
using System.ComponentModel;

namespace ApiProject.Application.Features.Auth.Command.Login
{
    public class LoginCommandRequest : IRequest<LoginCommandResponse>
    {
        [DefaultValue("melihomerkamar0@gmail.com")]
        public string Email { get; set; }
        [DefaultValue("123456")]
        public string Password { get; set; }
    }
}
