using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (double.TryParse(cleanString, out double result))
            {
                return result;
            }
            return 0;
        }
        public static string TaoMaHoaDon()
        {
            return "HD_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
        }
    }
}
