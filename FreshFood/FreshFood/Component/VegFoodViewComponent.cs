using Microsoft.AspNetCore.Mvc;

namespace FreshFood.Component
{
    public class VegFoodViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
