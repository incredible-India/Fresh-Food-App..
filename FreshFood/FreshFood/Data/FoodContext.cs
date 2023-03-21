using FreshFood.Models;using Microsoft.EntityFrameworkCore;

namespace FreshFood.Data
{
    public class FoodContext: DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options) :base(options) 
        {
            
        }
        public DbSet<veg> Foods { get; set; }
    }
}
