using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Cart> Carts { get; set; } = default!;

        public DbSet<CartDish> CartDishes { get; set; } = default!;

        public DbSet<Category> Categories { get; set; } = default!;

        public DbSet<Dish> Dishes { get; set; } = default!;

        public DbSet<Order> Orders { get; set; } = default!;

        public DbSet<Restaurant> Restaurants { get; set; } = default!;

        public DbSet<Role> Roles { get; set; } = default!;

        public DbSet<User> Users { get; set; } = default!;
    }
