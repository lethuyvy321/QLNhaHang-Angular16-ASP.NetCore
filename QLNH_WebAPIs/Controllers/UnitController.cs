using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNH_WebAPI.Models;
using QLNH_WebAPIs.Data;

namespace QLNH_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly MyDbContext _context;

        public UnitController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Unit> GetAll()
        {
            List<Unit> units = _context.Units.ToList();
            return units;
        }
    }
}
