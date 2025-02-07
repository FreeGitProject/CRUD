using CRUD.Category.Application.Abstractions.Messaging;

namespace CRUD.Category.Application.Categories.UpdateCategory
{
    public sealed record UpdateCategoryCommand(
      Guid CategoryId,
      string Name,
      string Description
  ) : ICommand;

}
