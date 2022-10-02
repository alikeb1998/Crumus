using Microsoft.AspNetCore.Mvc;

namespace OTP.Models.BaseModels;


    public  class Respond<T>:ControllerBase
    {
        public ResultModel<T> Model { get; set; }
        public IActionResult ActionRespond(ResultModel<T> Model)
        {
            this.Model = Model; 
            return Model.StatusCode switch
            {
                200 => Ok(Model),
                401 => Unauthorized(Model),
                404 => NotFound(Model),
                204 => NoContent(),
                _ => BadRequest(Model),
            };
        }


    }
