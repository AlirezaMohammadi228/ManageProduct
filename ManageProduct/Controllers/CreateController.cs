using ManageProduct.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManageProduct.Controllers
{
    public class CreateController : Controller
    {
        public static ProductRepository ProductRepository { get; set; } = new ProductRepository();
        public IActionResult Index()
        {
            return View(ProductRepository.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product model)
        {
            ProductRepository.Add(model);
            return RedirectToAction("Index");
        }
    }
}
