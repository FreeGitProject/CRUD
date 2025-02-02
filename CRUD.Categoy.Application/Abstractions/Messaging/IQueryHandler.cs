using CRUD.Category.Domain.Abstractions;
using MediatR;

namespace CRUD.Category.Application.Abstractions.Messaging
{
    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
        where TQuery : IQuery<TResponse>
    {
    }
}