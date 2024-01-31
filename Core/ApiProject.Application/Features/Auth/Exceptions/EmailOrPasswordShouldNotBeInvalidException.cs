using ApiProject.Application.Bases;

namespace ApiProject.Application.Features.Auth.Exceptions
{
    public class EmailOrPasswordShouldNotBeInvalidException : BaseExceptions
    {
        public EmailOrPasswordShouldNotBeInvalidException() : base("Kullanıcı Adı Veya Şifre Hatalı.") { }

    }
}
