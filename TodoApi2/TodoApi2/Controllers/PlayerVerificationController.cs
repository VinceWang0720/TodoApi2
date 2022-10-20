using Microsoft.AspNetCore.Mvc;

namespace TodoApi2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerVerificationController : ControllerBase
    {
        [HttpGet(Name = "GetPlayerVerification")]
        public PlayerInfo Get(string id,string token)
        {
            return new PlayerInfo
            {
                ID = id,
                Token = token
            };
        }
    }
}
