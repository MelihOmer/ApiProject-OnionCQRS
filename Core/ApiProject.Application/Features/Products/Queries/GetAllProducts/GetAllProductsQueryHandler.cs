using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
using MediatR;

namespace ApiProject.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await _unitOfWork.GetReadRepository<Product>().GetAllAsync();


            List<GetAllProductsQueryResponse> responseList = products.Select(x => new GetAllProductsQueryResponse
            {
                Title = x.Title,
                Price = x.Price - (x.Price*x.Discount/100), 
                Discount = x.Discount,
                Description = x.Description
            }).ToList();
            return responseList;
        }
    }
}
