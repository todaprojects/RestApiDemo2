using Microsoft.AspNetCore.Mvc;
using RestApiDemo_WebApi.Models;
using RestApiDemo_WebApi.Repositories;
using RestApiDemo_WebApi.Services;

namespace RestApiDemo_WebApi.Controllers
{
    [ApiController]
    [Route("api/shop/[controller]")]
    public class CookwareShoppingCartController : BaseShoppingCartController<Cookware>
    {
        public CookwareShoppingCartController(IItemRepository<Cookware> itemRepository,
            IShopService shopService) : base(itemRepository, shopService)
        {
        }
    }
}