namespace Application.Features.Clients.Queries;

public sealed record GetAllClientListQuery
    : IRequest<IEnumerable<ClientEntity>>
{
    public Func<ClientEntity, bool>? Predicate { get; }

    public GetAllClientListQuery(
        Func<ClientEntity, bool> predicate) =>
        Predicate = predicate;

    public GetAllClientListQuery() { }
}