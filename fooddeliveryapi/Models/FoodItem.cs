namespace FoodDeliveryAPI.Models;
public class FoodItem
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string ImageUrl { get; set; } = "";
    public decimal Price { get; set; }
}
