using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Commands.CarCommand;
namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CreateCarCommandHandler _createCommandHandler;
        private readonly GetCarByIDQueryHandler _getCarByIDQueryHandler;
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly GetCarWithBrandQueryHandler _getCarWithBrandQueryHandler;



        public CarController(GetCarWithBrandQueryHandler getCarWithBrandQueryHandler ,CreateCarCommandHandler createCommandHandler, GetCarByIDQueryHandler getCarByIDQueryHandler, GetCarQueryHandler getCarQueryHandler, UpdateCarCommandHandler updateCarCommandHandler, RemoveCarCommandHandler removeCarCommandHandler)
        {
            _createCommandHandler = createCommandHandler;
            _getCarByIDQueryHandler = getCarByIDQueryHandler;
            _getCarQueryHandler = getCarQueryHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllCar()
        {
            var values = await _getCarQueryHandler.Handle();

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarByID(int id)
        {
            var values = await _getCarByIDQueryHandler.Handle(new GetCarByIDQuery(id));

            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCar(RemoveCarCommand command)
        {
            await _removeCarCommandHandler.Handle(new RemoveCarCommand(command.CarId));

            return Ok("Araba silme işlemi başarılı");


        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await _updateCarCommandHandler.Handle(command);
            return Ok("Güncelleme başarılı");
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            await _createCommandHandler.Handle(command);
            return Ok("Araba Başarıyla eklendi");
        }
        [HttpGet("GetCarWithBrand")]
        public IActionResult GetCarWithBrand()
        {
            var values = _getCarWithBrandQueryHandler.Handle();

            return Ok(values);  
        }
    }
}
