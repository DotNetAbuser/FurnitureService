namespace Shared.Requests.Identity;

public record SignInRequest(
    [Required] string Username,
    [Required] string Password);