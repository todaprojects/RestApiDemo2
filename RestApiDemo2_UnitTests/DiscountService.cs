using FluentAssertions;
using RestApiDemo_WebApi.Services;
using Xunit;

namespace RestApiDemo2_UnitTests
{
    public class DiscountService
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(6, 10)]
        [InlineData(11, 20)]
        public void TestDiscountService1(int quantity, int discount)
        {
            var discountService = new ShopService();
            var discountValue = discountService.GetDiscount(quantity);
            discountValue.Should().Be(discount);
        }
    }
}