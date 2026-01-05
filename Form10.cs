using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            this.Load += Form10_Load;
            this.btntienmat.Click += btntienmat_Click;
            this.btnQA.Click += btnQA_Click;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            txtgiatridon.Text = PayHelper.ToVND(SessionData.TongTien);
            txtgiatridon.ReadOnly = true;
        }

        private void btntienmat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thanh toán tiền mặt?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool ketQua = PayHelper.ThanhToanVaLuuDuLieu();

                if (ketQua)
                {
                    MessageBox.Show("Thanh toán thành công!", "Thông báo");
                    SessionData.ClearSession();
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Close();
                }
            }
        }

        private void btnQA_Click(object sender, EventArgs e)
        {
            Form11 frmQR = new Form11();
            this.Hide();
            frmQR.ShowDialog();
            this.Close();
        }
    }
}