using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNH_WebAPI.Models;
using QLNH_WebAPIs.Data;

namespace QLNH_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly MyDbContext _context;

        public OrderItemController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<OrderItem> GetAll()
        {
            List<OrderItem> orderItems = _context.OrderItems.ToList();
            return orderItems;
        }
    }
}
