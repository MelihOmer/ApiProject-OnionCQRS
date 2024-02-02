using ApiProject.Application.Features.Brands.Command.CreateBrand;
using ApiProject.Application.Features.Brands.Queries.GetAllBrands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommandRequest request)
        {
            await _mediator.Send(request);
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBrands()
        {
            var values = await _mediator.Send(new GetAllBrandsQueryRequest());
            return Ok(values);

        }
    }
}
