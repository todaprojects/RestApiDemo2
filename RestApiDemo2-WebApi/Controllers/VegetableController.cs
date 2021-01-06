using Microsoft.AspNetCore.Mvc;
using RestApiDemo2_WebApi.Data;
using RestApiDemo2_WebApi.Models;
using RestApiDemo2_WebApi.Services;

namespace RestApiDemo2_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VegetableController : BaseItemController<Vegetable>
    {
        public VegetableController(IShopService<Vegetable> shopService, BaseItemContext context) : base(
            shopService, context)
        {
        }
    }
}