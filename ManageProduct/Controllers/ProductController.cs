using ManageProduct.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManageProduct.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository repository=new ProductRepository();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            var item=repository.Products.FirstOrDefault(p=>p.Id==id);
            return View(item);
        }
        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            var item = repository.Products.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                item.IsExist = false;
            }
            return RedirectToAction("Index");
        }
    }
}
