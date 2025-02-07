using CRUD.Category.Application.Abstractions.Caching;
using CRUD.Category.Application.Abstractions.Messaging;

namespace CRUD.Category.Application.Categories.GetCategory;

public sealed record GetCategoryQuery(Guid Id) : ICachedQuery<CategoryResponse>
{
    public string CacheKey => $"Categories-{Id}";

    public TimeSpan? Expiration => null;
}

//public sealed record GetCategoryQuery(Guid Id) : IQuery<CategoryResponse>;
