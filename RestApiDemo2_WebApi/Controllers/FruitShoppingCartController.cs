using Microsoft.AspNetCore.Mvc;
using RestApiDemo_WebApi.Interfaces;
using RestApiDemo_WebApi.Models;

namespace RestApiDemo_WebApi.Controllers
{
    [ApiController]
    [Route("api/shop/[controller]")]
    public class FruitShoppingCartController : BaseShoppingCartController<Fruit>
    {
        public FruitShoppingCartController(IItemRepository<Fruit> itemRepository, IShopService shopService) :
            base(itemRepository, shopService)
        {
        }
    }
}