using CarBook.Application.Features.CQRS.Commands.BrandCommand;
using CarBook.Application.Features.CQRS.Commands.CarCommand;
using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
using CarBook.Application.Features.CQRS.Queries.BrandQueries;
using CarBook.Application.Features.CQRS.Queries.CarQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly CreateBrandCommandHandler _createCommandHandler;
        private readonly GetBrandByIDQueryHandler _getBrandByIDQueryHandler;
        private readonly GetBrandQueryHandler _getBrandQueryHandler;
        private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;
        private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;

        public BrandController(CreateBrandCommandHandler createCommandHandler, GetBrandByIDQueryHandler getBrandByIDQueryHandler, GetBrandQueryHandler getBrandQueryHandler, UpdateBrandCommandHandler updateBrandCommandHandler, RemoveBrandCommandHandler removeBrandCommandHandler)
        {
            _createCommandHandler = createCommandHandler;
            _getBrandByIDQueryHandler = getBrandByIDQueryHandler;
            _getBrandQueryHandler = getBrandQueryHandler;
            _updateBrandCommandHandler = updateBrandCommandHandler;
            _removeBrandCommandHandler = removeBrandCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrands()
        {
            var values = await _getBrandQueryHandler.Handle();

            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandByID(int id)
        {
            var values = await _getBrandByIDQueryHandler.Handler(new GetBrandByIDQuery(id));
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBrand(RemoveBrandCommand command)
        {
            await _removeBrandCommandHandler.Handle(new RemoveBrandCommand(command.BrandID));
            return Ok("Brand silme işlemi başarılı");


        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandCommand command)
        {
            await _updateBrandCommandHandler.Handle(command);
            return Ok("Güncelleme başarılı");
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommand command)
        {
            await _createCommandHandler.Handle(command);
            return Ok("Araba Başarıyla eklendi");
        }
    }
}
