using System.ComponentModel.DataAnnotations;

namespace OTP.Models;

public class OtpRequest
{
    [Required]
    public string Mobile { get; set; }
}