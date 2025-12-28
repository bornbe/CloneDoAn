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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            this.txtloginnn.KeyDown += new KeyEventHandler(this.txtloginnn_KeyDown);
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
        }
        private void btnlog_Click(object sender, EventArgs e)
        {
            string inputPin = txtloginnn.Text;
            if (string.IsNullOrEmpty(inputPin))
            {
                MessageBox.Show("Vui lòng nhập mã PIN!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtloginnn.Focus();
                return;
            }
            long checkNumber;
            bool isNumeric = long.TryParse(inputPin, out checkNumber);

            if (!isNumeric)
            {
                MessageBox.Show("Mã PIN phải là số! Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtloginnn.Clear();
                txtloginnn.Focus();
                return;
            }
            if (inputPin == "123456")
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mã PIN không đúng. Vui lòng thử lại.", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtloginnn.Clear();
                txtloginnn.Focus();
            }
        }
        private void btnEx_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Close();
            }
            catch
            {
                Application.Exit();
            }
        }
        private void txtloginnn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlog.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
