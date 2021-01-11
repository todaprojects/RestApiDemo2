using FluentAssertions;
using RestApiDemo_WebApi.Services;
using Xunit;

namespace RestApiDemo2_UnitTests
{
    public class UnitTest1
    {
        private readonly ShopService _discountService = new ShopService();
        
        [Fact]
        public void TestDiscountService1()
        {
            var discount = _discountService.GetDiscount(1);
            discount.Should().Be(0);
        }
        
        [Fact]
        public void TestDiscountService2()
        {
            var discount = _discountService.GetDiscount(6);
            discount.Should().Be(10);
        }
        
        [Fact]
        public void TestDiscountService3()
        {
            var discount = _discountService.GetDiscount(11);
            discount.Should().Be(20);
        }
    }
}