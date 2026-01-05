using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using QuanLyBanHang.Models;

namespace QuanLyBanHang
{
    public static class PayHelper
    {
        public static string ToVND(double amount)
        {
            return amount.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
        }

        public static double FromVND(string moneyString)
        {
            if (string.IsNullOrEmpty(moneyString)) return 0;
            string cleanString = moneyString.Replace(".", "").Replace(",", "").Trim();
            if (double.TryParse(cleanString, out double result)) return result;
            return 0;
        }

        public static bool ThanhToanVaLuuDuLieu()
        {
            if (SessionData.GioHang == null || SessionData.GioHang.Count == 0) return false;

            using (var db = new QuanLyBanHangContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        DonHang dh = new DonHang();
                        dh.NgayBan = DateTime.Now;
                        db.DonHangs.Add(dh);
                        db.SaveChanges(); 

                        int idDonHangMoi = dh.MaDH; 
                        foreach (var item in SessionData.GioHang)
                        {
                            ChiTietDonHang ct = new ChiTietDonHang();
                            ct.MaDH = idDonHangMoi;
                            ct.MaMH = item.MaMH;
                            ct.SoLuongMua = item.SoLuong;
                            ct.ThanhTien = item.ThanhTien;
                            db.ChiTietDonHangs.Add(ct);
                            var matHang = db.MatHangs.FirstOrDefault(m => m.MaMH == item.MaMH);
                            if (matHang != null)
                            {
                                matHang.SoLuongTon = matHang.SoLuongTon - item.SoLuong;
                                matHang.SoLuongHienCo = matHang.SoLuongHienCo - item.SoLuong;
                                matHang.SoLuongDaBan = matHang.SoLuongDaBan + item.SoLuong;
                            }
                        }

                        db.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}