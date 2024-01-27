using ApiProject.Application.Dtos;
using ApiProject.Application.Interfaces.AutoMapper;
using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await _unitOfWork.GetReadRepository<Product>().GetAllAsync(include:x => x.Include(b => b.Brand));
            _mapper.Map<BrandDto, Brand>(new Brand());

            var mapList = _mapper.Map<GetAllProductsQueryResponse, Product>(products);
            foreach (var product in mapList)
                product.Price -= (product.Price * product.Discount / 100);
            return mapList;
        }
    }
}
