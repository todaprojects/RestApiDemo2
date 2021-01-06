using Microsoft.AspNetCore.Mvc;
using RestApiDemo2_WebApi.Data;
using RestApiDemo2_WebApi.Models;
using RestApiDemo2_WebApi.Services;

namespace RestApiDemo2_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FruitController : BaseItemController<Fruit>
    {
        public FruitController(IShopService<Fruit> shopService, BaseItemContext context) : base(shopService, context)
        {
        }
    }
}