namespace Application.Features.Clients.Queries;

public sealed record GetAllClientsListQuery
    : IRequest<IEnumerable<ClientEntity>>
{
    public Func<ClientEntity, bool>? Predicate { get; }

    public GetAllClientsListQuery(
        Func<ClientEntity, bool> predicate) =>
        Predicate = predicate;

    public GetAllClientsListQuery() { }
}