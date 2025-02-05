using CRUD.Category.Domain.Users;
using CRUD.Category.Infrastructure;
using CRUD.Categoy.Infrasturcture.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Category.Infrasturcture.Repositories
{
    internal sealed class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        //public override void Add(User user)
        //{
        //    foreach (var role in user.Roles)
        //    {
        //        DbContext.Attach(role);
        //    }

        //    DbContext.Add(user);
        //}
    }
}
