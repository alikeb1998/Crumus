namespace OTP.Models.BaseModels;

public class ResultModel<T>
{
    private const string MessageTemp = "با موفقیت انجام شد";
    public T Model { get; set; }
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public int StatusCode { get; set; }

    public ResultModel(T model, bool isSuccess = true, string message = MessageTemp, int statusCode = 200)
    {
        Model = model;
        IsSuccess = isSuccess;
        Message = message;
        StatusCode = statusCode;
    }
}