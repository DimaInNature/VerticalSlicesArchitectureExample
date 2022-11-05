namespace Application.Infrastructure.IoC.CQRS;

public static class MediatRConfiguration
{
    public static void AddCQRS(this IServiceCollection services)
    {
        services.AddMediatR(assemblies: Assembly.GetExecutingAssembly());

        services.AddClientMediatRProfile();
    }
}