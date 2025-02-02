using CRUD.Category.Domain.Categories;

namespace CRUD.Category.Application.Categories.GetCategory;

public sealed class CategoryResponse
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }
    public CategoryStatus IsActive { get; init; }
}