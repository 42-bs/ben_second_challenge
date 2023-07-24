namespace Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class DataPointHistoryController: ControllerBase
    {
        [HttpGet]
        public IActionResult Cavalinho()
        {
            return Ok("cavalinho");
        }
    }
}