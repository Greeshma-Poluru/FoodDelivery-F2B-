using Microsoft.EntityFrameworkCore;
using FoodDeliveryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using FoodDeliveryAPI.Data;
[ApiController]
[Route("api/[controller]")]
public class FoodController : ControllerBase
{
    private readonly AppDbContext _context;

    public FoodController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetItems()
    {
        return Ok(await _context.FoodItems.ToListAsync());
    }

    [HttpPost]
    public async Task<IActionResult> AddItem(FoodItem item)
    {
        _context.FoodItems.Add(item);
        await _context.SaveChangesAsync();
        return Ok(item);
    }
}
