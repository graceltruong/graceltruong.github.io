using Microsoft.EntityFrameworkCore;
using MIS3033_HW7_GraceTruong.Models;

namespace MIS3033_HW7_GraceTruong.Data
{
    public class OrderDB : DbContext// Change DbCon to your own database connect class name
    {
        public DbSet<Order> Orders { get; set; }// Define a table in the database. The table name here is: Students
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=129.15.67.240;Database=glthw7db;Port=5432;Username=truo0028;Password=Bbj06jjfmIoD80SsSP24");
        }
    }
}
