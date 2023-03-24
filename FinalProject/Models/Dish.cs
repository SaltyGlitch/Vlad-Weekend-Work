using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;

public class Dish
{
    [Key] public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public Category Category { get; set; }
    [Required]
    public double Price { get; set; }
}