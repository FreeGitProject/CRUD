using CRUD.Category.Domain.Abstractions;
using MediatR;

namespace CRUD.Category.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
