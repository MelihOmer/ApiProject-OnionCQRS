using ApiProject.Application.Bases;

namespace ApiProject.Application.Features.Products.Exception
{
    public class ProductTitleMustNotBeSameException : BaseExceptions
    {
        public ProductTitleMustNotBeSameException():base("Aynı Başlıkta Ürün Mevcut.")
        {
            
        }
    }
}
