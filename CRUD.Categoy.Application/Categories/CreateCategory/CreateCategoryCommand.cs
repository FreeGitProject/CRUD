using CRUD.Category.Application.Abstractions.Messaging;
using MediatR;

namespace CRUD.Category.Application.Categories.CreateCategory;

public sealed record CreateCategoryCommand(string Name, string Description) : ICommand<Guid>;