using ManageProduct.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManageProduct.Controllers
{

    public class ProductController : Controller
    {
        public static ProductRepository Repository { get; set; } = new();
        public IActionResult Index()
        {
            return View(Repository.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            Repository.Add(product);
            return RedirectToAction("Index");

        }
        public IActionResult Update(int id)
        {
            var model = Repository.GetById(id);
            return View(model);

        }
        public IActionResult Update(Product model)
        {
            var preModel = Repository.GetById(model.Id);
            preModel.Name = model.Name;
            preModel.Price = model.Price;
            preModel.productType = model.productType;
            return RedirectToAction("Index");
        }
    }
}
