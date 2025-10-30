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
            Products.Remove(product);
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
