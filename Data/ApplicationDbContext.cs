using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebBanHang.Models.Entities;

namespace WebBanHang.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JD1MVM7\\SQLEXPRESS; Database=WebBH; MultipleActiveResultSets = True; Trusted_connection = True; TrustServerCertificate = True;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DonHang>()
                .HasOne<KhachHang>(s => s.KhachHang)
                .WithMany(g => g.DonHangs)
                .HasForeignKey(s => s.IDKhachHang);
       
       
            modelBuilder.Entity<DonHang>()
                .HasOne<QuanLy>(s => s.QuanLy)
                .WithMany(g => g.DonHangss)
                .HasForeignKey(s => s.IDQuanLy);

            modelBuilder.Entity<SanPham>()
                .HasOne<Loai>(s => s.Loai)
                .WithMany(g => g.SanPhams)
                .HasForeignKey(s => s.IDLoai);

            modelBuilder.Entity<CT_DonHang>().HasKey(sc => new { sc.IDDonHang, sc.IDSanPham });

        

    }
        public DbSet<QuanLy> QuanLy { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<DonHang> DonHang { get; set; }
        public DbSet<Loai> Loai { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<CT_DonHang> CT_DonHang { get; set; }
    }
}
