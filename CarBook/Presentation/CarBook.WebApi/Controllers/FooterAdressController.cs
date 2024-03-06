using CarBook.Application.Features.Mediator.Commands.FooterAdressCommand;
using CarBook.Application.Features.Mediator.Queries.FooterAdressQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterAdressController : ControllerBase
    {
        private readonly IMediator mediator;

        public FooterAdressController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> FooterAdressList()
        {
            var values = await mediator.Send(new GetFooterAdressQuery());

            return Ok(values);  
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> FooterAdressByID(int id)
        {
            var value = await mediator.Send(new GetFooterAdressByIDQuery(id));

            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFooterAdress(CreateFooterAdressCommand command)
        {
            await mediator.Send(command);

            return Ok("Footer adresi eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFooterAdress(UpdateFooterAdressCommand command)
        {
            await mediator.Send(command);
            return Ok("Footer Adresi güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveFooterAdress(int id)
        {
            await mediator.Send(new RemoveFooterAdressCommand(id));

            return Ok("Footer Adresi Silindi");
        }

        
    
    
    }
}
