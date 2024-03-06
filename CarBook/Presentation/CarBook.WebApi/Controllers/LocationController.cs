using CarBook.Application.Features.Mediator.Commands.LocationCommand;
using CarBook.Application.Features.Mediator.Queries.LocationQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IMediator mediator;

        public LocationController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> LocationList()
        {
            var value = await mediator.Send(new GetLocationQuery());

            return Ok(value);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLocation(int id)
        {
            var value = await mediator.Send(new GetLocationByIDQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateLocation(CreateLocationCommand command)
        {
            await mediator.Send(command);
            return Ok("Location Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateLocation(UpdateLocationCommand command)
        {
            await mediator.Send(command);
            return Ok("Locvation Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveLocation(int id)
        {
            await mediator.Send(new RemoveLocationCommand(id));
            return Ok("Location silimndi");
        }
             
    }
}
