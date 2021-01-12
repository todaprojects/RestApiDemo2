using FluentAssertions;
using RestApiDemo_WebApi.Controllers;
using Xunit;

namespace RestApiDemo2_UnitTests
{
    public class ItemControllerTest
    {
        [Fact]
        public void GetItemTest()
        {
            var itemRepository = new MockItemRepository();
            var controller = new FruitItemController(itemRepository);

            controller.GetItem(1).Result.Id.Should().Be(1);
            controller.GetAll().Result.Should().NotBeNull();
        }
    }
}