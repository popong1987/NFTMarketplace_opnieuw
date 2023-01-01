namespace NFTMarketplace_webapplicaties_opnieuw.Models
{
    public class OrderProduct
    {
        public int OrderProductId { get; set; }
        public int Aantal { get; set; }
        public decimal Prijs { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        //navigation properties

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
