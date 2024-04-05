namespace Shared.Requests.Identity;

public record RegistrationRequest(
    [Required] string LastName,
    [Required] string FirstName,
    string MiddleName,
    [Required] string Username,
    [Required] string Password,
    [Required] [EmailAddress] string Email,
    [Required] [Phone] string Phone);