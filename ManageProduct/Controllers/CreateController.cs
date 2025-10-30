using ManageProduct.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManageProduct.Controllers
{
    public class CreateController : Controller
    {
        public static ProductRepository ProductRepository { get; set; } = new ProductRepository();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(Product model)
        {
            ProductRepository.Add(model);
            return RedirectToAction("Index");
        }
    }
}
