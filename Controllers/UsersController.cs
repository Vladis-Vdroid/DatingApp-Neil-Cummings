using APIDatingApp.Data;
using APIDatingApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIDatingApp.Controllers;


[ApiController]
[Route("api/[controller]")]
public class UsersController(DataContext context) : ControllerBase
{
    
    [HttpGet]
    public ActionResult<IEnumerable<AppUser>> GetUsers()
    {
        var users = context.Users.ToList();
        return users;
    }
    [HttpGet("{id}")] //api/users/2..etc
    public ActionResult<AppUser> GetUser(int id)
    {
        var user = context.Users.Find(id);
        if (user == null) return NotFound();
        return user;
    }

    
}

