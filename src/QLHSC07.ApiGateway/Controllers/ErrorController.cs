using QLHSC07.CORE;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QLHSC07.ApiGateway.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ErrorController : ControllerBase
    {
        [HttpGet]
        public ActionResult AccessDenied()
        {
            //return BadRequest(new ResponseErrorData
            //{
            //    ErrorType = ErrorTypeConstant.AccessDenied,
            //    ErrorMessage = StringMessage.ErrorMessages.AccessDenied
            //});
            return StatusCode(StatusCodes.Status401Unauthorized);
        }

        [HttpGet]
        public ActionResult ForbiddenAccess()
        {
            return StatusCode(StatusCodes.Status403Forbidden);
        }
    }
}
