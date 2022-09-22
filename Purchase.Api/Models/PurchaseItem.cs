namespace Purchase.Api.Models
{
    public class PurchaseItem
    {
        public int Id { get; set; }
        public string? PurchaseItems { get; set; }
        public decimal? PurchaseQty { get; set; }
        public decimal? PurchaseRate { get; set; }
        public decimal? PurchaseAmount { get; set; }
        public int SupplierId { get; set; }

    }
}
