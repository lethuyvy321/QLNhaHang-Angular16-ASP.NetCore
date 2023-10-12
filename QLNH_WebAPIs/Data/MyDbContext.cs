using Microsoft.EntityFrameworkCore;
using QLNH_WebAPI.Models;
using QLNH_WebAPIs.Models;

namespace QLNH_WebAPIs.Data
{
    public class MyDbContext :DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<GuestTable> GuestTables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ItemImage> Images { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitType> UnitsType { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
        { 
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
