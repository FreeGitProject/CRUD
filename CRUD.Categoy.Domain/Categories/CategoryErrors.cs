

using CRUD.Category.Domain.Abstractions;

namespace CRUD.Category.Domain.Categories
{
    public static class CategoryErrors
    {
        public static readonly Error NotFound = new(
       "Category.Found",
       "The user with the specified identifier was not found");

        public static readonly Error InvalidCredentials = new(
            "Category.InvalidCredentials",
            "The provided credentials were invalid");
    }
}
