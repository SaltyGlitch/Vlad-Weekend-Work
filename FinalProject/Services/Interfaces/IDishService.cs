using FinalProject.Models;

namespace FinalProject.Services.Interfaces;

public interface IDishService
{
    Task<List<Dish>> GetAllDishes();
    Task<Dish> GetDishBGetById(int id);
}