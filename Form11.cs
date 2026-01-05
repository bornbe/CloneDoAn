using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            this.Load += Form11_Load;
            this.btnhttthd.Click += btnhttthd_Click;
            this.pictureBox1.Click += PictureBox1_Click;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(pictureBox1, "Nhấn vào đây để chọn ảnh QR khác");
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            string tenFile = "qr_cuahang.png";
            string duongDan = Path.Combine(Application.StartupPath, tenFile);
            if (File.Exists(duongDan)) HienThiAnh(duongDan);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MoHopThoaiChonAnh();
        }

        private void MoHopThoaiChonAnh()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                HienThiAnh(openFileDialog.FileName);
            }
        }

        private void HienThiAnh(string path)
        {
            try { pictureBox1.Image = Image.FromFile(path); pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; }
            catch { }
        }

        private void btnhttthd_Click(object sender, EventArgs e)
        {
            bool ketQua = PayHelper.ThanhToanVaLuuDuLieu();

            if (ketQua)
            {
                MessageBox.Show("Giao dịch hoàn tất! Cảm ơn quý khách.", "Thông báo");
                SessionData.ClearSession();
                Form1 f1 = new Form1();
                f1.Show();
                this.Close();
            }
        }
    }
}