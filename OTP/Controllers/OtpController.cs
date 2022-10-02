using Microsoft.AspNetCore.Mvc;
using OTP.Models;
using OTP.Models.BaseModels;
using OTP.Service.IServices;

namespace OTP.Controllers;

[Produces("application/json")]
[Route("V1/[controller]")]
public class OtpController : Controller
{
    private readonly IOtpService _otpService;

    public OtpController(IOtpService otpService)
    {
        _otpService = otpService;
    }

    [HttpPost(nameof(SendOtp))]
    public async Task<IActionResult> SendOtp(OtpRequest request)
        => new Respond<Otp>().ActionRespond(await _otpService.SendOtp(request));

    [HttpPost(nameof(CheckOtp))]
    public async Task<IActionResult> CheckOtp(CheckRequest request)
        => new Respond<bool>().ActionRespond(await _otpService.CheckOtp(request));
}