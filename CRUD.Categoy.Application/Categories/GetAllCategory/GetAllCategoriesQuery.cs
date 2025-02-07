using CRUD.Category.Application.Abstractions.Caching;

namespace CRUD.Category.Application.Categories.GetAllCategory
{
    public sealed record GetAllCategoriesQuery : ICachedQuery<IReadOnlyList<CategoryListResponse>>
    {
        public string CacheKey => "Categories";

        public TimeSpan? Expiration => null;
    }

}
