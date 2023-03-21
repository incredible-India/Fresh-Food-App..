using FreshFood.Data;
using FreshFood.Models;
using FreshFood.Repository;
using Microsoft.EntityFrameworkCore;

namespace FreshFood.Repository
{
    public class FoodServices : _FoodServices
    {
        private readonly FoodContext _foodContext;
     

        public FoodServices(FoodContext foodContext) { 
        
                _foodContext = foodContext;
          
        }


        public async Task<int> AddFood(veg f)
        {
            veg model = new veg()
            {
                Name = f.Name,
                Description = f.Description,
                ImageUrl = f.ImageUrl,
                Price = f.Price,
                Quantiy = f.Quantiy,
                Type = f.Type,
                
            };

 
          await   _foodContext.AddAsync(model);
          await  _foodContext.SaveChangesAsync();


            return f.Id;
        }

        public int DeleteAllFood(int id)
        {
            throw new NotImplementedException();
        }

        public int DeleteFoodById(int id)
        {
            throw new NotImplementedException();
        }

        public veg EditFoodById()
        {
            throw new NotImplementedException();
        }

        //return the list of the all the food which is addd to the this page
        public List<veg> GetAllFood()
        {
           return _foodContext.Foods.ToList();
        }

        public veg GetFoodByID(int id)
        {
            throw new NotImplementedException();
        }


        //for the components

        public async Task<List<veg>> GetTopVegFood()
        {
            return _foodContext.Foods.Take(4).ToList();
        }
    }
}
