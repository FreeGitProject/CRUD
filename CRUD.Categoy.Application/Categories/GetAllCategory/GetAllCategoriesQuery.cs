using CRUD.Category.Application.Abstractions.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Category.Application.Categories.GetAllCategory
{
    public sealed record GetAllCategoriesQuery : IQuery<IReadOnlyList<CategoryListResponse>>;

}
