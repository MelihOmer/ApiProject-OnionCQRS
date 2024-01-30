using ApiProject.Application.Bases;
using ApiProject.Application.Features.Products.Rules;
using ApiProject.Application.Interfaces.AutoMapper;
using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace ApiProject.Application.Features.Products.Common.CreateProduct
{
    public class CreateProductCommandHandler :BaseHandler,IRequestHandler<CreateProductCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ProductRules productRules;

        public CreateProductCommandHandler(ProductRules productRules ,IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContext):base(mapper, unitOfWork, httpContext)
        {
        }


        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Product> products = await unitOfWork.GetReadRepository<Product>().GetAllAsync();
            //Rules-ProductTitleMustNotBeSame
            #region productAddedRules
            await productRules.ProductTitleMustNotBeSame(request.Title, products);
            #endregion



            Product product = new(request.Title, request.Description, request.BrandId, request.Price, request.Discount);
            await unitOfWork.GetWriteRepository<Product>().AddAsync(product);
            if (await unitOfWork.SaveAsync() > 0)
            {
                foreach (var categoryId in request.CategoryIds)
                    await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new()
                    {
                        ProductId = product.Id,
                        CategoryId = categoryId
                    });
                await unitOfWork.SaveAsync();
            }
            return Unit.Value;

        }
    }
}
