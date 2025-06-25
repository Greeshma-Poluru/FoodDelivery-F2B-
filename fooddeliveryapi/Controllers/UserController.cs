using FoodDeliveryAPI.Data;
using FoodDeliveryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly AppDbContext _context;

    public UserController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return Ok(user);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(User user)
    {
        var existing = await _context.Users
            .FirstOrDefaultAsync(x => x.Username == user.Username && x.Password == user.Password);
        if (existing == null) return Unauthorized();
        return Ok(existing);
    }
}
