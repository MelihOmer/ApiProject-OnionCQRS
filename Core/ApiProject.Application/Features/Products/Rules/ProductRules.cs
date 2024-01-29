using ApiProject.Application.Bases;
using ApiProject.Application.Features.Products.Exception;
using ApiProject.Domain.Entities;

namespace ApiProject.Application.Features.Products.Rules
{
    public class ProductRules : BaseRules
    {
        public  Task ProductTitleMustNotBeSame(string requestTitle,IList<Product> productList)
        {
            if (productList.Any(x => x.Title == requestTitle)) throw new ProductTitleMustNotBeSameException();   

            return Task.CompletedTask;
        }
    }
}
