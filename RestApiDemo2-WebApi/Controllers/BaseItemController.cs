using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApiDemo2_WebApi.Data;
using RestApiDemo2_WebApi.Models;
using RestApiDemo2_WebApi.Services;

namespace RestApiDemo2_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseItemController<T> : ControllerBase
        where T : BaseItem
    {
        private readonly IShopService<T> _shopService;

        public BaseItemController(IShopService<T> shopService, BaseItemContext context)
        {
            _shopService = shopService;
            _shopService.Context = context;
        }

        [HttpGet]
        public async Task<List<T>> GetAll()
        {
            return await _shopService.GetAllItemsAsync();
        }

        [HttpGet("{id}")]
        public async Task<T> GetItem(int id)
        {
            return await _shopService.GetItemAsync(id);
        }

        [HttpPost]
        public async Task AddItem(T t)
        {
            await _shopService.AddItemAsync(t);
        }

        [HttpPut("{id}")]
        public async Task EditItem(int id, T t)
        {
            await _shopService.EditItemAsync(id, t);
        }

        [HttpDelete("{id}")]
        public async Task DeleteItem(int id)
        {
            await _shopService.DeleteItemAsync(id);
        }
    }
}