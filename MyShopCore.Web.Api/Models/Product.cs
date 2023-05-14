namespace MyShopCore.Web.Api.Models
{
    public class Product:Audit
    {
        public Guid Id { get; set; }
        public required string Title { get; init; }
        public string Description { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int OrderAfter { get; set; }
       
    }
}
