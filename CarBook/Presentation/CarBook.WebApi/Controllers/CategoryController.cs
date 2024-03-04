using CarBook.Application.Features.CQRS.Commands.AboutCommand;
using CarBook.Application.Features.CQRS.Commands.CategoryCommand;
using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.CategoryHandler;
using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using CarBook.Application.Features.CQRS.Queries.CategoryQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CreateCategoryCommandHandler _createCommandHandler;
        private readonly GetCategoryByIDQueryHandler _getCategoryByIDQueryHandler;
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
        private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;
        private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;

        public CategoryController(CreateCategoryCommandHandler createCommandHandler, GetCategoryByIDQueryHandler getCategoryByIDQueryHandler, GetCategoryQueryHandler getCategoryQueryHandler, UpdateCategoryCommandHandler updateCategoryCommandHandler, RemoveCategoryCommandHandler removeCategoryCommandHandler)
        {
            _createCommandHandler = createCommandHandler;
            _getCategoryByIDQueryHandler = getCategoryByIDQueryHandler;
            _getCategoryQueryHandler = getCategoryQueryHandler;
            _updateCategoryCommandHandler = updateCategoryCommandHandler;
            _removeCategoryCommandHandler = removeCategoryCommandHandler;
        }
    

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {

            var values = await _getCategoryQueryHandler.Handle();

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutByID(int id)
        {
            var value = await _getCategoryByIDQueryHandler.Handle(new GetCategoryByIDQuery(id));

            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateCategoryCommand command)
        {
            await _createCommandHandler.Handle(command);

            return Ok("Category bilgisi eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAbout(int id)
        {
            await _removeCategoryCommandHandler.Handle(new RemoveCategoryCommand(id));

            return Ok("Kategori bilgisi silindi");
        }


        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateCategoryCommand command)
        {
            await _updateCategoryCommandHandler.Handle(command);
            return Ok("Kategori bilgisi güncellendi");
        }
    }
}
