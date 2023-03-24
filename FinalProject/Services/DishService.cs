using FinalProject.Models;
using FinalProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Services;

public class DishService : IDishService
{
    private Context _context { get; set; }

    public DishService(Context context)
    {
        _context = context;
    }
    
    public Task<Dish> GetDishBGetById(int id)
        => _context.Dishes.FirstAsync(dish => dish.Id == id);
    
    public async Task<List<Dish>> GetAllDishes() // Doesn't really make a lot of sense. The restaurants already hold all the Dishes.
        => await QueryAllDishes().ToListAsync();
    
    private IQueryable<Dish> QueryAllDishes()
        => _context.Dishes;
}