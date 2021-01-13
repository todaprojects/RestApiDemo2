using RestApiDemo_WebApi.Models;

namespace RestApiDemo_WebApi.Services
{
    public interface IShopService
    {
        ShoppingCart Sell<T>(T requestedItem, int quantity) where T : BaseItem;
    }
}