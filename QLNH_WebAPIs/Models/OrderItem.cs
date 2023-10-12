using QLNH_WebAPIs.Models;
using System.ComponentModel.DataAnnotations;

namespace QLNH_WebAPI.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int parentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool voided { get; set; }
        public double SalePrice { get; set; }
        public virtual Item Item { get; set; }
    }
}
