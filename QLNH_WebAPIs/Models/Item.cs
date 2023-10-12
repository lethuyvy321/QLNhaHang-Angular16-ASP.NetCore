using QLNH_WebAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace QLNH_WebAPIs.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Discount { get; set;}
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Category Category { get; set; }
        public virtual IList<ItemImage> ItemImage { get; set; }
    }
}
