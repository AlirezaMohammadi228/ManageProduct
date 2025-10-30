using ManageProduct.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManageProduct.Controllers
{
    public class ProductController : Controller
    {
        public static ProductRepository productRepository = new ProductRepository();

        public IActionResult Index() =>
            View(productRepository.Filtering(ProductType.None, string.Empty));
                      
        public IActionResult Filter(ProductType productType,string st) =>
            View(productRepository.Filtering(productType, st));
    }
}
