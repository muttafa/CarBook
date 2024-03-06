using CarBook.Application.Features.Mediator.Commands.PricingCommand;
using CarBook.Application.Features.Mediator.Queries.PricingQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricingController : ControllerBase
    {
        private readonly IMediator mediator;

        public PricingController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> PricingList()
        {
            var value = await mediator.Send(new GetPricingQuery());
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrice(int id)
        {
            var value = await mediator.Send(new GetPricingByIDQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePricing(CreatePricingCommand command)
        {
            await mediator.Send(command);
            return Ok("PricingOluşturuldu");
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePricing(UpdatePricingCommand command)
        {
            await mediator.Send(command);
            return Ok("Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemovePricing(int id)
        {
            await mediator.Send(new RemovePricingCommand(id));
            return Ok("Silindi");
        }
    }
}
