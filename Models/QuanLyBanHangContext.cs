using System.Data.Entity;

namespace QuanLyBanHang.Models
{
    public class QuanLyBanHangContext : DbContext
    {
        // Kết nối đến chuỗi connection string tên là "Model1" hoặc "QuanLyBanHangContext" trong App.config
        public QuanLyBanHangContext() : base("name=Model1")
        {
        }

        public DbSet<MatHang> MatHangs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}