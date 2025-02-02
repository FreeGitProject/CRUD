using CRUD.Category.Domain.Abstractions;

namespace CRUD.Category.Domain.Categories.Events;
public sealed record CategoryCreatedDomainEvent(
    Guid CategoryId,
    string Name,
    string Description,
    CategoryStatus Status
) : IDomainEvent;