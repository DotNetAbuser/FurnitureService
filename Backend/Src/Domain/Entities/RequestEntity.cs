namespace Domain.Entities;

public class RequestEntity : BaseEntity<Guid>
{
    public string Furniture{ get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
}