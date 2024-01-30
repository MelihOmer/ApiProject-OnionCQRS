using ApiProject.Application.Bases;

namespace ApiProject.Application.Features.Auth.Exceptions
{
    public class UserAlreadyExistException : BaseExceptions
    {
        public UserAlreadyExistException():base("Böyle bir kullanıcı zaten var!") { }
        
    }
}
