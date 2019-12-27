namespace QuickBuy.Domain.Entities
{
    public class OderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
