using FreshFood.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FreshFood.Controllers
{
    public class AdminController : Controller
    {
        private readonly _FoodServices _foodServices;

        /*    public AdminController(FoodServices foodServices)
            {
                _foodServices = foodServices;
            }
    */



        [Route("/Admin")]

        public async Task<IActionResult> Index()
        {
            return View(_foodServices.GetAllFood());
        }
    }
}
