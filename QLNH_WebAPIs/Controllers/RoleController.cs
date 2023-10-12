using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNH_WebAPI.Models;
using QLNH_WebAPIs.Data;

namespace QLNH_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly MyDbContext _context;

        public RoleController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Role> GetAll()
        {
            List<Role> roles = _context.Roles.ToList();
            return roles;
        }
        [HttpGet("Id")]
        public Role GetById([FromQuery] int id)
        {
            return _context.Roles.Where(r => r.Id == id).FirstOrDefault();
        }
        [HttpPost]
        public Role Post([FromQuery] Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role;
        }
    }
}
