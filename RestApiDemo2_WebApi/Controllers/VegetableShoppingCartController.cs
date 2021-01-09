using Microsoft.AspNetCore.Mvc;
using RestApiDemo_WebApi.Models;
using RestApiDemo_WebApi.Repositories;
using RestApiDemo_WebApi.Services;

namespace RestApiDemo_WebApi.Controllers
{
    [ApiController]
    [Route("api/shop/[controller]")]
    public class VegetableShoppingCartController : BaseShoppingCartController<Vegetable>
    {
        public VegetableShoppingCartController(IItemRepository<Vegetable> itemRepository,
            IShopService shopService) : base(itemRepository, shopService)
        {
        }
    }
}