using System.ComponentModel.DataAnnotations;

namespace OTP.Models;

public class CheckRequest
{
    [Required]
    public string Mobile { get; set; }
    [Required]
    public string OtpId { get; set; }
    [Required]
    public string Code { get; set; }
}