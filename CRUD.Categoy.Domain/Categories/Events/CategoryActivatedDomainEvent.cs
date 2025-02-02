using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Category.Domain.Abstractions;

namespace CRUD.Category.Domain.Categories.Events
{
    public sealed record CategoryActivatedDomainEvent(Guid CategoryId, CategoryStatus Status) : IDomainEvent;

}
