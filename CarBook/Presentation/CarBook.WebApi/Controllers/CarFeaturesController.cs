using CarBook.Application.Features.CQRS.Commands.CarFeatureCommand;
using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarFeatureHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
using CarBook.Application.Features.CQRS.Queries.CarFeatureQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarFeaturesController : ControllerBase
    {
        private readonly CreateCarFeatureCommandHandler _createCommandHandler;
        private readonly GetCarFeatureByIDQueryHandler _getCarFeatureByIDQueryHandler;
        private readonly GetCarFeatureQueryHandler _getCarFeatureQueryHandler;
        private readonly UpdateCarFeatureCommandHandler _updateCarFeatureCommandHandler;
        private readonly RemoveCarFeatureCommandHandler _removeCarFeatureCommandHandler;

        public CarFeaturesController(CreateCarFeatureCommandHandler createCommandHandler, GetCarFeatureByIDQueryHandler getCarFeatureByIDQueryHandler, GetCarFeatureQueryHandler getCarFeatureQueryHandler, UpdateCarFeatureCommandHandler updateCarFeatureCommandHandler, RemoveCarFeatureCommandHandler removeCarFeatureCommandHandler)
        {
            _createCommandHandler = createCommandHandler;
            _getCarFeatureByIDQueryHandler = getCarFeatureByIDQueryHandler;
            _getCarFeatureQueryHandler = getCarFeatureQueryHandler;
            _updateCarFeatureCommandHandler = updateCarFeatureCommandHandler;
            _removeCarFeatureCommandHandler = removeCarFeatureCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCarFeatures()
        {
            var value = await _getCarFeatureQueryHandler.Handle();

            return Ok(value);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIDCarFeature(int id)
        {
            var value = await _getCarFeatureByIDQueryHandler.Handle(new GetCarFeatureByIDQuery(id));

            return Ok(value);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveFeature(RemoveCarFeatureCommand command)
        {
            await _removeCarFeatureCommandHandler.Handle(new RemoveCarFeatureCommand(command.CarFeatureID));

            return Ok("Başarılı");
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateCarFeatureCommand command)
        {
            await _createCommandHandler.Handle(command);

            return Ok("Başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateCarFeatureCommand command)
        {
            await _updateCarFeatureCommandHandler.Handle(command);
            return Ok("Güncelleme başarılı");
        }
    }
}
