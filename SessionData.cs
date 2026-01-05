using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    public class CartItem
    {
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public int SoLuong { get; set; } 
        public double DonGia { get; set; }
        public double ThanhTien { get; set; }
    }
    public static class SessionData
    {
        public static List<CartItem> GioHang = new List<CartItem>();
        public static double TongTien = 0;
        public static void ClearSession()
        {
            GioHang.Clear();
            TongTien = 0;
        }
    }
}