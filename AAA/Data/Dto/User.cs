using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AAA.Data.Dto;

[Index(nameof(UserName), nameof(MobileNumber), nameof(NationalCode), nameof(Email), nameof(SessionId), IsUnique = true)]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [MaxLength(20)] public string UserName { get; set; }
    public string Password { get; set; }
    [Phone] public string? MobileNumber { get; set; }
    public string NationalCode { get; set; }
    [EmailAddress] public string? Email { get; set; }
    public string? Address { get; set; }
    public bool IsRemoved { get; set; }
    public bool IsActive { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }

    public Guid? SessionId { get; set; }
    public DateTime? SessionAt { get; set; }
}