using System.ComponentModel.DataAnnotations;

namespace QLNH_WebAPI.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool Voided { get; set; }
        public double TotalPrice { get; set; }
        public double PaidAmount { get; set; }
        public virtual IList<OrderItem> OrderItem {  get; set; } 
    }
}
