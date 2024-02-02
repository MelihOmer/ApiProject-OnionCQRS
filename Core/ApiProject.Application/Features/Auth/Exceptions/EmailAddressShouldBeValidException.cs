using ApiProject.Application.Bases;

namespace ApiProject.Application.Features.Auth.Exceptions
{
    public class EmailAddressShouldBeValidException : BaseExceptions
    {
        public EmailAddressShouldBeValidException() : base("Böyle Bir Email Adresi Bulunamadı.") { }

    }
}
