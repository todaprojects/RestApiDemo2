using Microsoft.AspNetCore.Mvc;
using RestApiDemo_WebApi.Models;
using RestApiDemo_WebApi.Repositories;

namespace RestApiDemo_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VegetableItemController : BaseItemController<Vegetable>
    {
        public VegetableItemController(IItemRepository<Vegetable> context) : base(context)
        {
        }
    }
}