using CRUD.Category.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Category.Domain.Categories.Events
{
    public sealed record CategoryDeactivatedDomainEvent(Guid CategoryId, CategoryStatus Status) : IDomainEvent;
}
