using System.ComponentModel.DataAnnotations;

namespace UserManagementApi.Models;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required, StringLength(100, MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;

    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Range(0, 120)]
    public int Age { get; set; }
}
