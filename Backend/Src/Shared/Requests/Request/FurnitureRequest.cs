namespace Shared.Requests.Request;

public record FurnitureRequest
{
    public FurnitureRequest()
    {
    }

    public FurnitureRequest(string furniture, string description)
    {
        Furniture = furniture;
        Description = description;
    }
    [Required] public string Furniture { get; set; }
    [Required] public string Description { get; set; }
}