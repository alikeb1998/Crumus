using OTP.Service.IServices;
using OTP.Service.Services;

namespace OTP.Utils;

public static class InjectHandler
{
    public static IServiceCollection InjectServices(this IServiceCollection services)
    {
        services.AddScoped<IOtpService, OtpService>();
        return services;
    }
}