using ManageProduct.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManageProduct.Controllers
{

    public class ProductController : Controller
    {
        public static ProductRepository Repository { get; set; } = new();
        //public IActionResult Index()
        //{
        //    return View(Repository);
        //}
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("Name", "Price", "Quantity", "productType")] Product product)
        {
            Repository.Add(product);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            Repository.Delete(Repository.GetById(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = Repository.GetById(id);
            return View(model);

        }
        [HttpPost]
        public IActionResult Update(int id, [Bind("Name", "Price", "Quantity", "productType")] Product model)
        {
            Repository.Update(model, id);
            return RedirectToAction("Index");
        }
        public static ProductRepository productRepository = new ProductRepository();

        [HttpGet]
        public IActionResult Index() =>
            View(productRepository.Filtering(ProductType.None, string.Empty));

        [HttpPost]
        public IActionResult Index(ProductType productType,string st) =>
            View(productRepository.Filtering(productType, st));
    }
}
