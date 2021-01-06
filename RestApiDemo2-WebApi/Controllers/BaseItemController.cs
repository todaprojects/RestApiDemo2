using System.Collections.Generic;
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
            _shopService.Items = context.Set<T>();
        }

        [HttpGet]
        public List<T> GetAll()
        {
            return _shopService.GetAllItems();
        }

        [HttpGet("{id}")]
        public T GetItem(int id)
        {
            return _shopService.GetItem(id);
        }

        [HttpPost]
        public void AddItem(T t)
        {
            _shopService.AddItem(t);
        }

        [HttpDelete("{id}")]
        public void DeleteItem(int id)
        {
            _shopService.DeleteItem(id);
        }

        [HttpPut("{id}")]
        public void EditItem(int id, T t)
        {
            _shopService.EditItem(id, t);
        }
    }
}