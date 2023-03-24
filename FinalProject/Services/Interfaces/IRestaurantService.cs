using FinalProject.Models;

namespace FinalProject.Services.Interfaces;

public interface IRestaurantService
{
    Task<List<Restaurant>> GetAllRestaurants();
    Task<Restaurant> GetRestaurantById(int id);
    Task<List<Restaurant>> FilterRestaurantsBySearchBar(string input);
}