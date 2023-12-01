// Controllers/UserController.cs

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    public UserController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult GetUsers()
    {
        var users = _dbContext.Users.ToList();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetUserById(int id)
    {
        var user = _dbContext.Users.Find(id);

        if (user == null)
        {
            return NotFound($"User with ID {id} not found");
        }

        return Ok(user);
    }

    [HttpPost]
    public IActionResult CreateUser(User user)
    {
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
        return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateUser(int id, User user)
    {
        var existingUser = _dbContext.Users.Find(id);

        if (existingUser == null)
        {
            return NotFound($"User with ID {id} not found");
        }

        existingUser.Username = user.Username;
        existingUser.Mail = user.Mail;
        existingUser.PhoneNumber = user.PhoneNumber;
        existingUser.Skillsets = user.Skillsets;
        existingUser.Hobby = user.Hobby;

        _dbContext.SaveChanges();
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteUser(int id)
    {
        var user = _dbContext.Users.Find(id);

        if (user == null)
        {
            return NotFound($"User with ID {id} not found");
        }

        _dbContext.Users.Remove(user);
        _dbContext.SaveChanges();
        return Ok();
    }
}

