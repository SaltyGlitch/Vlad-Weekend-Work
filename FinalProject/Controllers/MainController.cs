using FinalProject.Models;
using FinalProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MainController : ControllerBase
{
    private IRestaurantService RestaurantService { get; set; }
    private IDishService DishService { get; set; }

    public MainController(IRestaurantService restaurantService, IDishService dishService)
    {
        RestaurantService = restaurantService;
        DishService = dishService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Restaurant>>> GetAllRestaurants() =>
        await RestaurantService.GetAllRestaurants(); // Check if Empty. If empty, return BadRequest

    [HttpGet]
    [Route("search/{input}")]
    public async Task<ActionResult<List<Restaurant>>> FilterRestaurantsFromSearch(string input)
        => await RestaurantService.FilterRestaurantsBySearchBar(input);

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<Restaurant>> GetRestaurantById(int id)
        => await RestaurantService.GetRestaurantById(id);
}