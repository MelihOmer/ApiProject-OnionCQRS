using ApiProject.Application.Bases;

namespace ApiProject.Application.Features.Auth.Exceptions
{
    public class RefreshTokenShouldNotBeExpiredException : BaseExceptions
    {
        public RefreshTokenShouldNotBeExpiredException() : base("Oturum Süresi Sona Ermiştir. Lütfen Tekrar Giriş Yapın.") { }

    }
}
