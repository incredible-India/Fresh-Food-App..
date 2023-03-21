using FreshFood.Models;

namespace FreshFood.Repository
{
    public interface  _FoodServices
    {

        public Task<int> AddFood(veg f);
        public List<veg> GetAllFood();
        public veg GetFoodByID(int id);
        public int DeleteFoodById(int id);
        public veg EditFoodById();
        public int DeleteAllFood(int id);
        //for the view components

        public Task<List<veg>> GetTopVegFood();
    }
}
