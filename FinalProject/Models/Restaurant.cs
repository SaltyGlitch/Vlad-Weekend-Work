using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;

public class Restaurant
{
    [Key] public int Id { get; set; }
    [Required] public string Name { get; set; }
    [Required] public string Description { get; set; }
    [Required] public string Location { get; set; }
    [Required] public double DeliveryCost { get; set; }
    [Required] public string MainPictureUrl { get; set; }
    public List<Dish> Dishes { get; set; }
}