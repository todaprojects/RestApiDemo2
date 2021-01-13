namespace RestApiDemo_WebApi.Helpers
{
    public class DiscountHelper
    {
        public static int GetDiscount(int quantity)
        {
            if (quantity < 5)
            {
                return 0;
            }
            
            return quantity > 10 ? 20 : 10;
        }
        
        public static decimal ApplyDiscount(int discount)
        {
            return (decimal)(100 - discount) / 100;
        }
    }
}