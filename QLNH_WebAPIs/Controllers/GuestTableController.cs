using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNH_WebAPI.Models;
using QLNH_WebAPIs.Data;

namespace QLNH_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestTableController : ControllerBase
    {
        private readonly MyDbContext _context;

        public GuestTableController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<GuestTable> GetAll()
        {
            List<GuestTable> guestTables = _context.GuestTables.ToList();
            return guestTables;
        }
    }
}
