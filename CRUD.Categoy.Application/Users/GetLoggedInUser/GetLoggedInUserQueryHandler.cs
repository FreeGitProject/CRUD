﻿using CRUD.Category.Application.Abstractions.Authentication;
using CRUD.Category.Application.Abstractions.Data;
using CRUD.Category.Application.Abstractions.Messaging;
using CRUD.Category.Domain.Abstractions;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Category.Application.Users.GetLoggedInUser
{
    internal sealed class GetLoggedInUserQueryHandler
        : IQueryHandler<GetLoggedInUserQuery, UserResponse>
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;
        private readonly IUserContext _userContext;

        public GetLoggedInUserQueryHandler(
            ISqlConnectionFactory sqlConnectionFactory,
            IUserContext userContext)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
            _userContext = userContext;
        }

        public async Task<Result<UserResponse>> Handle(
            GetLoggedInUserQuery request,
            CancellationToken cancellationToken)
        {
            using var connection = _sqlConnectionFactory.CreateConnection();

            const string sql = """
            SELECT
                id AS Id,
                first_name AS FirstName,
                last_name AS LastName,
                email AS Email
            FROM users
            WHERE identity_id = @IdentityId
            """;

            var user = await connection.QuerySingleAsync<UserResponse>(
                sql,
                new
                {
                    _userContext.IdentityId
                });

            return user;
        }
    }
}
