namespace AAA.Models;

public class User
{
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? MobileNumber { get; set; }
    public string? NationalCode { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public bool IsRemoved { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid? SessionId { get; set; }
    public DateTime? SessionAt { get; set; }
   
    
}