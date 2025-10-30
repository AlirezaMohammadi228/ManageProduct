using Microsoft.AspNetCore.Mvc;

namespace ManageProduct.Models
{
    public class ProductRepository
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public decimal TotalValue()
        {
            return Products.Sum(x => x.Quantity * x.Price);
        }
        public void Add(Product product)
        {
            Products.Add(product);
        }
        public void ConfirmDelete(int id)
        {
            var item = Products.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                item.IsExist = false;
            }
            
        }
        public void Edit(Product product)
        {
           
        }
        public List<Product> GetAll()
        {
            return Products;
        }
        public Product GetById(int id)
        {
            return Products.FirstOrDefault( x => x.Id == id);
        }
    }
}
