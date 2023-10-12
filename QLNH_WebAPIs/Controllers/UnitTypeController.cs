using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNH_WebAPI.Models;
using QLNH_WebAPIs.Data;

namespace QLNH_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitTypeController : ControllerBase
    {
        private readonly MyDbContext _context;

        public UnitTypeController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<UnitType> GetAll()
        {
            List<UnitType> unitTypes = _context.UnitsType.ToList();
            return unitTypes;
        }
    }
}
