using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;

public class Cart
{
    [Key] public int Id { get; set; }
    public List<CartDish> CartDishes { get; set; }
    public double TotalPrice { get; set; }
}