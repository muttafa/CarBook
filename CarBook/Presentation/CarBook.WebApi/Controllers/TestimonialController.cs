using CarBook.Application.Features.Mediator.Commands.SocialMediaCommand;
using CarBook.Application.Features.Mediator.Commands.TestimonialCommand;
using CarBook.Application.Features.Mediator.Queries.SocialMediaQueries;
using CarBook.Application.Features.Mediator.Queries.TestimonialsQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly IMediator mediator;

        public TestimonialController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            var value = await mediator.Send(new GetTestimonialQuery());
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial(int id)
        {
            var value = await mediator.Send(new GetTestimonialByIDQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command)
        {
            await mediator.Send(command);
            return Ok("Testimonial Oluşturuldu");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand command)
        {
            await mediator.Send(command);
            return Ok("Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveTestimonial(int id)
        {
            await mediator.Send(new RemoveTestimonialCommand(id));
            return Ok("Silindi");
        }
    }
}
