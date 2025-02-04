using CRUD.Category.Application.Categories.CreateCategory;
using CRUD.Category.Application.Categories.DeleteCategory;
using CRUD.Category.Application.Categories.GetAllCategory;
using CRUD.Category.Application.Categories.GetCategory;
using CRUD.Category.Application.Categories.UpdateCategory;
using CRUD.Category.Domain.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Category.Api.Controllers.Categories
{
    [ApiController]
    [Route("api/[controller]")]

    public class CategoryController : ControllerBase
    {
        private readonly ISender _sender;

        public CategoryController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories(
      CancellationToken cancellationToken)
        {
            var query = new GetAllCategoriesQuery();

            Result<IReadOnlyList<CategoryListResponse>> result = await _sender.Send(query, cancellationToken);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }

            return Ok(result.Value);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(Guid id, CancellationToken cancellationToken)
        {
            var query = new GetCategoryQuery(id);

            Result<CategoryResponse> result = await _sender.Send(query, cancellationToken);

            return result.IsSuccess ? Ok(result.Value) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(
            CreateCategoryRequest request,
            CancellationToken cancellationToken)
        {
            var command = new CreateCategoryCommand(
                request.Name,
                request.Description
                );

            Result<Guid> result = await _sender.Send(command, cancellationToken);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }

            return CreatedAtAction(nameof(GetCategory), new { id = result.Value }, result.Value);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(
           Guid id,
           UpdateCategoryRequest request,
           CancellationToken cancellationToken)
        {
          
            var command = new UpdateCategoryCommand(
                id,
                request.Name,
                request.Description
            );

            Result result = await _sender.Send(command, cancellationToken);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(Guid id, CancellationToken cancellationToken)
        {
            var command = new DeleteCategoryCommand(id);

            Result result = await _sender.Send(command, cancellationToken);

            if (result.IsFailure)
            {
                return NotFound(result.Error);
            }

            return NoContent();
        }
    }
}
