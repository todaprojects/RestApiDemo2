using RestApiDemo_WebApi.Models;

namespace RestApiDemo_WebApi.Services
{
    public class ShopService : IShopService
    {
        public int GetDiscount(int quantity)
        {
            if (quantity < 5)
            {
                return 0;
            }
            
            return quantity > 10 ? 20 : 10;
        }

        public ShoppingCart Sell<T>(T requestedItem, int quantity) where T : BaseItem
        {
            var discount = GetDiscount(quantity);
            
            return new ShoppingCart
            {
                Item = requestedItem,
                PurchaseQuantity = quantity,
                PurchaseDiscount = discount,
                PurchaseAmount = requestedItem.Price * (100 - discount)/100 * quantity
            };
        }
    }
}