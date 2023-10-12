using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNH_WebAPI.Models;
using QLNH_WebAPIs.Data;

namespace QLNH_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly MyDbContext _context;

        public StatusController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Status> GetAll()
        {
            List<Status> statuses = _context.Status.ToList();
            return statuses;
        }
    }
}
