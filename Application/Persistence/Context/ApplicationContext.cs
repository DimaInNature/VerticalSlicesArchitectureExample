namespace Application.Persistence.Context;

public class ApplicationContext : DbContext
{
    public DbSet<ClientEntity> Clients => Set<ClientEntity>();

    public DbSet<ProductEntity> Products => Set<ProductEntity>();

    public DbSet<SaleContractEntity> SaleContract => Set<SaleContractEntity>();

    public ApplicationContext(DbContextOptions options) : base(options) =>
        Database.EnsureCreated();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        base.OnModelCreating(modelBuilder);
}