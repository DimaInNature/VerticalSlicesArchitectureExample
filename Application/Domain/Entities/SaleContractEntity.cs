namespace Application.Domain.Entities;

public class SaleContractEntity
{
    public Guid Id { get; set; }

    public Guid? ClientId { get; set; }

    public ClientEntity? Client { get; set; }

    public Guid? ProductId { get; set; }

    public ProductEntity? Product { get; set; }

    public decimal Cost { get; set; }
}