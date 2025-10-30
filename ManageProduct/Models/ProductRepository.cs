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
            return Products.FirstOrDefault(x => x.Id == id);
        }
       
        public List<Product> Filtering(ProductType productType,string searchedTitle)
        {
            List<Product> finded = Products;

            if (productType != ProductType.None) 
            {
                finded = finded.Where(x => x.productType == productType)
                                 .ToList();
            }
           
           if ( !string.IsNullOrWhiteSpace(searchedTitle) &&  searchedTitle.Length>=3){
            finded= finded.Where(x => x.Name.Contains(searchedTitle))
                          .ToList();
            }
            
            return finded;
            
 
            
            
        }


    }
}
