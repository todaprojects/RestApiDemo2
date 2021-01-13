using Microsoft.AspNetCore.Mvc;
using RestApiDemo_WebApi.Interfaces;
using RestApiDemo_WebApi.Models;

namespace RestApiDemo_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FruitItemController : BaseItemController<Fruit>
    {
        public FruitItemController(IItemRepository<Fruit> context) : base(context)
        {
        }
    }
}