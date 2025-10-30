using Microsoft.AspNetCore.Mvc;

namespace ManageProduct.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
