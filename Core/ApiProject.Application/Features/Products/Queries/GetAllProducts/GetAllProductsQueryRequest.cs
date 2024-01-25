using MediatR;

namespace ApiProject.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryRequest: IRequest<IList<GetAllProductsQueryResponse>>
    {
        
    }
}
