using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNH_WebAPIs.Data;
using QLNH_WebAPIs.Models;

namespace QLNH_WebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MyDbContext _context;

        public UserController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            List<User> users = _context.Users.ToList();
            return users;
        }
    }
}
