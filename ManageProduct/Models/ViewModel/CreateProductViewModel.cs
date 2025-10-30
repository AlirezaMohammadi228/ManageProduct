namespace ManageProduct.Models.ViewModel
{
    public class CreateProductViewModel
    {
        //TODO : درست کردن اسم 
        public string Title { get; set; }
        public decimal Price { get; set; }
        public ProductType productType { get; set; }
        public int Quantity { get; set; }
    }
}
