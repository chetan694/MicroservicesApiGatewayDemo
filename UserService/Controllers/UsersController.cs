using Microsoft.AspNetCore.Mvc;
using UserService.Model;


[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    static List<string> users = new();

    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok(users);
    }

    [HttpPost]
    public IActionResult AddUser([FromBody] User user)
    {
        users.Add(user.Name);
        return Ok("User added");
    }
}
