using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;

public class Role
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Type { get; set; }
}