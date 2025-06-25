using Microsoft.EntityFrameworkCore;
using FoodDeliveryAPI.Models;

namespace FoodDeliveryAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<FoodItem> FoodItems => Set<FoodItem>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();
}
