namespace Application.Persistence.DependencyInjection;

public static class ApplicationContextConfiguration
{
    public static void AddDatabaseConfiguration(
       this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<DbContext, ApplicationContext>();

        services.AddDbContextPool<ApplicationContext>(options =>
        {
            options.UseSqlite(connectionString: configuration.GetConnectionString(name: "Sqlite"));
        });
    }
}