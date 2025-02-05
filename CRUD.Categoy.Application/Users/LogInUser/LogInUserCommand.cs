using CRUD.Category.Application.Abstractions.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Category.Application.Users.LogInUser
{
    public sealed record LogInUserCommand(string Email, string Password)
      : ICommand<AccessTokenResponse>;
}
