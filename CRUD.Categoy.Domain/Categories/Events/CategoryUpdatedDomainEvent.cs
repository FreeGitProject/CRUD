using CRUD.Category.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Category.Domain.Categories.Events
{
    public sealed record CategoryUpdatedDomainEvent(
        Guid CategoryId,
        string OldName,
        string NewName,
        string OldDescription,
        string NewDescription,
        CategoryStatus Status
    ) : IDomainEvent;
}
