namespace Domain.Entities;

public class StatusEntity : BaseEntity<int>
{
    public string Name { get; set; }

    public List<RequestEntity> Requests { get; set; } = [];
}