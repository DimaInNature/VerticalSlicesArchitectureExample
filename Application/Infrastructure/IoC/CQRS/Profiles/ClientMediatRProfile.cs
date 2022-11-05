namespace Application.Infrastructure.IoC.CQRS.Profiles;

internal static class ClientMediatRProfile
{
    public static void AddClientMediatRProfile(this IServiceCollection services)
    {
        services.AddScoped<IRequest<IEnumerable<ClientEntity>>, GetAllClientsListQuery>();
        services.AddScoped<IRequestHandler<GetAllClientsListQuery, IEnumerable<ClientEntity>>, GetAllClientsListQueryHandler>();
    }
}