using System.Reflection;

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
        public void Delete(Product product)
        {
            product.IsExist = false;
        }
        public void Update(Product product, int id)
        {
            var preModel = GetById(id);
            preModel.Name = product.Name;
            preModel.Price = product.Price;
            preModel.productType = product.productType;
        }
        public List<Product> GetAll()
        {
            return Products.Where(x => x.IsExist == true).ToList();
        }
        public Product GetById(int id)
        {
            return Products.FirstOrDefault(x => x.Id == id);
        }
    }
}
