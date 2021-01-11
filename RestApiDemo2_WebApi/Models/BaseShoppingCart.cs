namespace RestApiDemo_WebApi.Models
{
    public abstract class BaseShoppingCart
    {
        public BaseItem Item { get; set; }
        
        public int PurchaseQuantity { get; set; }
        
        public int PurchaseDiscount { get; set; }
        
        public decimal PurchaseAmount { get; set; }
    }
}