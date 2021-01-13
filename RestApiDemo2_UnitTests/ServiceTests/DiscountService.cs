using FluentAssertions;
using RestApiDemo_WebApi.Models;
using RestApiDemo_WebApi.Services;
using Xunit;

namespace RestApiDemo2_UnitTests.ServiceTests
{
    public class DiscountService
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(6, 10)]
        [InlineData(11, 20)]
        public void TestDiscountService1(int quantity, int discount)
        {
            var item = new Cookware();
            var shopService = new ShopService();
            
            var shoppingCart = shopService.Sell(item ,quantity);
            
            shoppingCart.PurchaseDiscount.Should().Be(discount);
        }
    }
}