using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNH_WebAPI.Models;
using QLNH_WebAPIs.Data;
using QLNH_WebAPIs.Models;

namespace QLNH_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly MyDbContext _context;

        public CategoryController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Category> GetAll()
        {
            List<Category> categories = _context.Categories.ToList();
            return categories;
        }
    }
}
