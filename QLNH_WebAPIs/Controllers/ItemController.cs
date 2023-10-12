using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLNH_WebAPIs.Data;
using QLNH_WebAPIs.Models;

namespace QLNH_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly MyDbContext _context;

        public ItemController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Item> GetAll()
        {
            List<Item> items = _context.Items.ToList();
            return items;
        }
    }
}
