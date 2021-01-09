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
    }
}