using System.ComponentModel.DataAnnotations;

namespace QLNH_WebAPI.Models
{
    public class GuestTable
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Status Status { get; set; }
        public virtual Guest Guest { get; set; }
    }
}
