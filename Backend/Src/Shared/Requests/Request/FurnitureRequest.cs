namespace Shared.Requests.Request;

public record FurnitureRequest(
    [Required] string Furniture,
    [Required] string Description);