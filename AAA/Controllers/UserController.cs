using Microsoft.AspNetCore.Mvc;

namespace AAA.Controllers;

[Produces("application/json")]
[Route("V1/[controller]")]
public class UserController : Controller
{
    
    //  [HttpPost(nameof(CreateOne))]
    // public async Task<IActionResult> CreateOne()
    //     => new Respond<Otp>().ActionRespond(await _otpService.SendOtp(request));
}