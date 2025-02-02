using CRUD.Category.Application.Categories.CreateCategory;
using CRUD.Category.Application.Categories.GetCategory;
using CRUD.Category.Domain.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
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
    }
}
