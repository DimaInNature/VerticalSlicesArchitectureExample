namespace Application.Domain.Entities;

public class ClientEntity
{
    public Guid Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public IEnumerable<SaleContractEntity>? SellingHistory { get; set; }
}