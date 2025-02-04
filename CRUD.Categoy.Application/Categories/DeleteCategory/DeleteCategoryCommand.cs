using CRUD.Category.Application.Abstractions.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Category.Application.Categories.DeleteCategory
{
    public sealed record DeleteCategoryCommand(Guid CategoryId) : ICommand;

}
