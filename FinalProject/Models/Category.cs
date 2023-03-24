using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    public string Categoy { get; set; }
}