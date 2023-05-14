namespace MyShopCore.Web.Api.Models
{
    public class Audit
    {
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updted { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
