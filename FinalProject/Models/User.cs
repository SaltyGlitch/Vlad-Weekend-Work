using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;

public class User
{
    [Key] public int Id { get; set; }

    [Required] public Role Role { get; set; }
    [Required] public string FirstName { get; set; }
    [Required] public string LastName { get; set; }
    [Required] public string Email { get; set; }
    [Required] public string Address { get; set; }
    [Required] public string PhoneNumber { get; set; }
    public Cart Cart { get; set; }
    public List<Order> Orders { get; set; }
}