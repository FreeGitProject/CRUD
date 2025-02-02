using CRUD.Category.Application.Abstractions.Data;
using CRUD.Category.Domain.Categories;
using Dapper;
using System.Data;
using CRUD.Category.Domain.Abstractions;
using CRUD.Category.Application.Abstractions.Messaging;

namespace CRUD.Category.Application.Categories.GetCategory;

//internal sealed class GetCategoryQueryHandler : IQueryHandler<GetCategoryQuery, CategoryResponse>
//{
//    private readonly ISqlConnectionFactory _sqlConnectionFactory;
//    public GetCategoryQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
//    {
//        _sqlConnectionFactory = sqlConnectionFactory;
//    }

//    public async Task<Result<CategoryResponse>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
//    {
//        using IDbConnection connection = _sqlConnectionFactory.CreateConnection();

//        const string sql = """
//                           SELECT
//                               id AS Id,
//                               name AS Name,
//                               description AS Description,
//                               status AS IsActive
//                           FROM category
//                           """;

//        CategoryResponse? category = await connection.QueryFirstOrDefaultAsync<CategoryResponse>(
//            sql,
//            new
//            {
//                request.Id
//            });

//        if (category is null)
//        {
//            return Result.Failure<CategoryResponse>(CategoryErrors.NotFound);
//        }

//        return category;
//    }
//}

internal sealed class GetCategoryQueryHandler : IQueryHandler<GetCategoryQuery, CategoryResponse>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;
    public GetCategoryQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result<CategoryResponse>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
    {
        using IDbConnection connection = _sqlConnectionFactory.CreateConnection();

        const string sql = """
                           SELECT
                               id AS Id,
                               name AS Name,
                               description AS Description,
                               status AS IsActive
                           FROM category
                           Where id=@Id
                           """;

        CategoryResponse? category = await connection.QueryFirstOrDefaultAsync<CategoryResponse>(
            sql,
            new
            {
                request.Id
            });

        if (category is null)
        {
            return Result.Failure<CategoryResponse>(CategoryErrors.NotFound);
        }

        return category;
    }
}