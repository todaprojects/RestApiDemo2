using RestApiDemo_WebApi.Helpers;
using RestApiDemo_WebApi.Interfaces;
using RestApiDemo_WebApi.Models;

namespace RestApiDemo_WebApi.Services
{
    public class ShopService : IShopService
    {
        public ShoppingCart Sell<T>(T requestedItem, int quantity) where T : BaseItem
        {
            var discount = Discount.GetDiscount(quantity);
            
            return new ShoppingCart
            {
                Item = requestedItem,
                PurchaseQuantity = quantity,
                PurchaseDiscount = discount,
                PurchaseAmount = requestedItem.Price * Discount.ApplyDiscount(discount) * quantity
            };
        }
    }
}