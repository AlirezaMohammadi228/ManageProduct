namespace ManageProduct.Models
{
    public enum ProductType
    {
        None = 0,
        Clothes = 1,
        Detergent = 2,
        Food = 3,
    }
    public class Product
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductType productType { get; set; }
        public int Quantity { get; set; }
        public int Id { get; set; }
        public static int _nextId { get; set; } = 1;
        public bool IsExist { get; set; }
        public Product()
        {
            Id = _nextId++;
            IsExist = true;
        }
    }
}
