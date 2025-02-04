using CRUD.Category.Application.Abstractions.Data;
using CRUD.Category.Application.Abstractions.Messaging;
using CRUD.Category.Domain.Abstractions;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Category.Application.Categories.GetAllCategory
{
    internal sealed class GetAllCategoriesQueryHandler
     : IQueryHandler<GetAllCategoriesQuery, IReadOnlyList<CategoryListResponse>>
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public GetAllCategoriesQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
        }

        public async Task<Result<IReadOnlyList<CategoryListResponse>>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            using IDbConnection connection = _sqlConnectionFactory.CreateConnection();

            const string sql = """
            SELECT 
                Id, 
                Name, 
                Description, 
                Status
            FROM category
        """;

            IEnumerable<CategoryListResponse> categories = await connection.QueryAsync<CategoryListResponse>(sql);

            return categories.ToList();
        }
    }
}
