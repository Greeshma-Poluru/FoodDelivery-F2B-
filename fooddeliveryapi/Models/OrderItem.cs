namespace FoodDeliveryAPI.Models;
public class OrderItem
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int FoodItemId { get; set; }
    public FoodItem? FoodItem { get; set; }
    public int Quantity { get; set; }
}
