namespace Application.Features.Clients.Queries;

public class GetAllClientsListQueryHandler
    : IRequestHandler<GetAllClientsListQuery, IEnumerable<ClientEntity>>
{
    private readonly ApplicationContext _context;

    public GetAllClientsListQueryHandler(
        ApplicationContext context) =>
        _context = context;

    public async Task<IEnumerable<ClientEntity>> Handle(
        GetAllClientsListQuery request,
        CancellationToken cancellationToken)
    {
        if (request.Predicate is null)
        {
            return await Task.FromResult(result:
                _context.Clients.AsNoTracking()
                .AsEnumerable());
        }

        return await Task.FromResult(result: 
            _context.Clients.AsNoTracking()
            .Where(predicate: request.Predicate)
            .AsEnumerable());
    }
}