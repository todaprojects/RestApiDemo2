using Microsoft.AspNetCore.Mvc;
using RestApiDemo_WebApi.Models;
using RestApiDemo_WebApi.Repositories;

namespace RestApiDemo_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CookwareItemController : BaseItemController<Cookware>
    {
        public CookwareItemController(IItemRepository<Cookware> context) : base(context)
        {
        }
    }
}