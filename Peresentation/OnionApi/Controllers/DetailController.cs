using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionAplication.Features.Details.Command.CreateProduct;
using OnionAplication.Features.Details.Command.DeleteDetail;
using OnionAplication.Features.Details.Command.UpdateDetail;
using OnionAplication.Features.Details.Quaries;
using OnionAplication.Features.Products.Command.CreateProduct;
using OnionAplication.Features.Products.Command.DeleteProduct;
using OnionAplication.Features.Products.Command.UpdateProduct;
using OnionAplication.Features.Products.Quaries.GetAllProducts;

namespace OnionApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DetailController : ControllerBase
    {
        private readonly IMediator mediator;

        public DetailController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDetails()
        {
            var response = await mediator.Send(new GetAllDetailsQueryRequest());
            return Ok(response);

        }
        [HttpPost]
        public async Task<IActionResult> CreateDetail(CreateDetailCommnadRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateDetail(UpdateDetailCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteDetail(DeleteDetailCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
    }
}
