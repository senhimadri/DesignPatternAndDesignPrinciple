using DIby_IAmTimCorey.Logic;
using Microsoft.AspNetCore.Mvc;

namespace DIby_IAmTimCorey.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserInterfaceController : ControllerBase
{
    private DemoLogic logic;


    public UserInterfaceController()
    {
        logic= new();
    }


    [HttpGet]
    [Route("GetInstance")]
    public IActionResult GetInstance()
    {

        return Ok((logic.Value1,logic.Value2));
    }
}
