using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApiDemo_WebApi.Interfaces;
using RestApiDemo_WebApi.Models;

namespace RestApiDemo_WebApi.Controllers
{
    [ApiController]
    [Route("api/shop/[controller]")]
    public abstract class BaseShoppingCartController<T> : ControllerBase
        where T : BaseItem
    {
        private readonly IItemRepository<T> _itemRepository;
        private readonly IShopService _shopService;
        
        public BaseShoppingCartController(IItemRepository<T> itemRepository, IShopService shopService)
        {
            _itemRepository = itemRepository;
            _shopService = shopService;
        }
        
        [HttpGet ("{id}/{quantity}")]
        public async Task<ShoppingCart> SellItem(int id, int quantity)
        {
            var requestedItem = await _itemRepository.GetItemAsync(id);

            return _shopService.Sell(requestedItem, quantity);
        }
    }
}