
using OTP.Models;
using OTP.Models.BaseModels;

namespace OTP.Service.IServices;

public interface IOtpService
{
   Task<ResultModel<Otp>> SendOtp(OtpRequest requestequest);
   Task<ResultModel<bool>> CheckOtp(CheckRequest request);
}