using OTP.Models;
using OTP.Models.BaseModels;
using OTP.Service.IServices;

namespace OTP.Service.Services;

public class OtpService : IOtpService
{
    public async Task<ResultModel<Otp>> SendOtp(OtpRequest otpRequest) =>
       new(new Otp { Code = "99999", OtpId = Guid.NewGuid().ToString() });
    
    public async Task<ResultModel<bool>> CheckOtp(CheckRequest request)
        => new(request.Code.Equals("99999"));
}