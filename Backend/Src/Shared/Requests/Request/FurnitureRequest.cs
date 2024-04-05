namespace Shared.Requests.Request;

public record FurnitureRequest(
    [Required] string UserId,
    [Required] string FurnitureName,
    [Required] string Description);