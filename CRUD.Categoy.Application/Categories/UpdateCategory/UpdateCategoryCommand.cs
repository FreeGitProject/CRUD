using CRUD.Category.Application.Abstractions.Messaging;
using CRUD.Category.Domain.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Category.Application.Categories.UpdateCategory
{
    public sealed record UpdateCategoryCommand(
      Guid CategoryId,
      string Name,
      string Description
  ) : ICommand;

}
