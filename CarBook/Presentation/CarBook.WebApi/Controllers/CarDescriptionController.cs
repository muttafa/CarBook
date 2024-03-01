using CarBook.Application.Features.CQRS.Commands.CarDescriptionCommand;
using CarBook.Application.Features.CQRS.Commands.CarFeatureCommand;
using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarDescriptionHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarFeatureHandlers;
using CarBook.Application.Features.CQRS.Queries.CarDescriptionQueries;
using CarBook.Application.Features.CQRS.Queries.CarFeatureQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarDescriptionController : ControllerBase
    {
        private readonly CreateCarDescriptionCommandHandler _createCommandHandler;
        private readonly GetCarDescriptionByIDQueryHandler _getCarDescriptionByIDQueryHandler;
        private readonly GetCarDescriptionQueryHandler _getCarDescriptionQueryHandler;
        private readonly UpdateCarDescriptionCommandHandler _updateCarDescriptionCommandHandler;
        private readonly RemoveCarDescriptionCommandHandler _removeCarDescriptionCommandHandler;

        public CarDescriptionController(CreateCarDescriptionCommandHandler createCommandHandler, GetCarDescriptionByIDQueryHandler getCarDescriptionByIDQueryHandler, GetCarDescriptionQueryHandler getCarDescriptionQueryHandler, UpdateCarDescriptionCommandHandler updateCarDescriptionCommandHandler, RemoveCarDescriptionCommandHandler removeCarDescriptionCommandHandler)
        {
            _createCommandHandler = createCommandHandler;
            _getCarDescriptionByIDQueryHandler = getCarDescriptionByIDQueryHandler;
            _getCarDescriptionQueryHandler = getCarDescriptionQueryHandler;
            _updateCarDescriptionCommandHandler = updateCarDescriptionCommandHandler;
            _removeCarDescriptionCommandHandler = removeCarDescriptionCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCarDescription()
        {
            var value = await _getCarDescriptionQueryHandler.Handle();
            return Ok(value);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIDCarDescription(int id)
        {
            var value = await _getCarDescriptionByIDQueryHandler.Handle(new GetCarDescriptionByIDQuery(id));
            return Ok(value);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveFeature(RemoveCarDescriptionCommand command)
        {
            await _removeCarDescriptionCommandHandler.Handle(new RemoveCarDescriptionCommand(command.CarDescriptionID));

            return Ok("Başarılı");
        }

        [HttpPost]
        public async Task<IActionResult> CreateDescription(CreateCarDescriptionCommand command)
        {
            await _createCommandHandler.Handle(command);

            return Ok("Başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDescription(UpdateCarDescriptionCommand command)
        {
            await _updateCarDescriptionCommandHandler.Handle(command);
            return Ok("Güncelleme başarılı");
        }
    }
}
