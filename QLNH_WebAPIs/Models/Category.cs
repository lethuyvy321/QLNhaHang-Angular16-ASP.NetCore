using QLNH_WebAPIs.Models;
using System.ComponentModel.DataAnnotations;

namespace QLNH_WebAPI.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public int parentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}
        public bool IsDeleted { get; set; }
        public virtual IList<Item> Items { get; set; }
    }
}
