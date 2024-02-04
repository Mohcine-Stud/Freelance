using System.ComponentModel.DataAnnotations;

namespace Freelance.Application.ViewModels.Authentication;

public record RegisterRequest(
        [Required]
        string FirstName,
        [Required]
        string LastName,
        [Required]
        string Email,
        [Required]
        string Password
    );

