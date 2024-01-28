using ApiProject.Application.Interfaces.AutoMapper;
using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
using MediatR;

namespace ApiProject.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = _mapper.Map<Product,UpdateProductCommandRequest>(request);

            var productCotegories = await _unitOfWork.GetReadRepository<ProductCategory>().GetAllAsync(x => x.ProductId == product.Id);

            await _unitOfWork.GetWriteRepository<ProductCategory>().HardDeleteRangeAsync(productCotegories);

            foreach (var categoryId in request.CategoryIds)
                await _unitOfWork.GetWriteRepository<ProductCategory>()
                    .AddAsync(new() { CategoryId = categoryId, ProductId = product.Id });

            await _unitOfWork.GetWriteRepository<Product>().UpdateAsync(map);
            await _unitOfWork.SaveAsync();
        }
    }
}
