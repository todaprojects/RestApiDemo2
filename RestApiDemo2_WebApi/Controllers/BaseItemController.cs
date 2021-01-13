using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApiDemo_WebApi.Interfaces;
using RestApiDemo_WebApi.Models;

namespace RestApiDemo_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseItemController<T> : ControllerBase
        where T : BaseItem
    {
        private readonly IItemRepository<T> _itemRepository;

        public BaseItemController(IItemRepository<T> itemRepository)
        {
            _itemRepository = itemRepository;
        }

        [HttpGet]
        public async Task<List<T>> GetAll()
        {
            return await _itemRepository.GetAllItemsAsync();
        }

        [HttpGet("{id}")]
        public async Task<T> GetItem(int id)
        {
            return await _itemRepository.GetItemAsync(id);
        }

        [HttpPost]
        public async Task AddItem(T t)
        {
            await _itemRepository.AddItemAsync(t);
        }

        [HttpPut("{id}")]
        public async Task EditItem(int id, T t)
        {
            await _itemRepository.EditItemAsync(id, t);
        }

        [HttpDelete("{id}")]
        public async Task DeleteItem(int id)
        {
            await _itemRepository.DeleteItemAsync(id);
        }
    }
}