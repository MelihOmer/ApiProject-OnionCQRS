using ApiProject.Application.Bases;
using ApiProject.Application.Features.Products.Rules;
using ApiProject.Application.Interfaces.AutoMapper;
using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace ApiProject.Application.Features.Products.Command.DeleteProduct
{
    public class DeleteProductCommandHandler :BaseHandler,IRequestHandler<DeleteProductCommandRequest, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductCommandHandler(ProductRules productRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContext) : base(mapper, unitOfWork, httpContext)
        {
        }

        public async Task<Unit> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            product.IsDeleted = true;
            await _unitOfWork.GetWriteRepository<Product>().UpdateAsync(product);
            await _unitOfWork.SaveAsync();
            return  Unit.Value;
        }
    }
}
