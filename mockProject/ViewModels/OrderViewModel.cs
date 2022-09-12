namespace mockProject.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }     
        public CustomerViewModel Customer { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}
