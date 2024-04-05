namespace Domain.Entities;

public class RequestEntity : BaseEntity<Guid>
{
    public int StatusId { get; set; }
    public Guid UserId { get; set; }
    
    public string FurnitureName { get; set; }
    public string Description { get; set; }

    public StatusEntity Status { get; set; } = null!;
    public List<UserEntity> Users { get; set; } = [];
    public List<RequestEntity> Requests { get; set; } = [];
}