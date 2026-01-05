using QuanLyBanHang.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += Form6_Load;
            this.btnoutt.Click += (s, e) => this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ReloadKhoHang();
        }

        public void ReloadKhoHang()
        {
            try
            {
                dgvCTSLH.Rows.Clear();
                using (var db = new QuanLyBanHangContext())
                {
                    var kho = db.MatHangs.AsNoTracking().ToList();

                    foreach (var item in kho)
                    {
                        int index = dgvCTSLH.Rows.Add(
                            item.MaMH,
                            item.TenMH,
                            item.SoLuongTon,
                            item.SoLuongDaBan
                        );

                        if (item.SoLuongTon < 10)
                        {
                            dgvCTSLH.Rows[index].DefaultCellStyle.BackColor = Color.Pink;
                            dgvCTSLH.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải kho: " + ex.Message);
            }
        }

        private void Form6_Load_1(object sender, EventArgs e)
        {
        }
    }
}