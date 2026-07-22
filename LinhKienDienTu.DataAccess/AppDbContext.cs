using LinhKienDienTu.Models;
using Microsoft.EntityFrameworkCore;

namespace LinhKienDienTu.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<LinhKien> LinhKiens { get; set; }
    }
}