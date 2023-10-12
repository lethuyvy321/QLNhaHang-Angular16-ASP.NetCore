using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNH_WebAPI.Models;
using QLNH_WebAPIs.Data;

namespace QLNH_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly MyDbContext _context;

        public GuestController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Guest> GetAll()
        {
            List<Guest> guests = _context.Guests.ToList();
            return guests;
        }
    }
}
