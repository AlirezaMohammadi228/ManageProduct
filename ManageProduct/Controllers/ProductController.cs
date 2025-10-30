using ManageProduct.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManageProduct.Controllers
{

    public class ProductController : Controller
    {
        public static ProductRepository Repository { get; set; } = new();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Update()
        {
            //var model = Repository.GetById(id);
            //return View(model);
            return View();
        }
        //public IActionResult Update(Product model)
        //{
        //    var preModel = Repository.GetById(model.Id);
        //    preModel.Name = model.Name;
        //    preModel.Price = model.Price;
        //    preModel.productType = model.productType;
        //    return RedirectToAction("Index");
        //}
    }
}
