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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // Đảm bảo Form hiển thị ở giữa màn hình khi mở
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // 1. Xử lý nút Nhập hàng -> Mở Form 4 (Nhập hàng)
        private void btnAddItean_Click(object sender, EventArgs e)
        {
            // Ẩn Form 3 tạm thời
            this.Hide();

            // Khởi tạo và mở Form 4
            Form4 f4 = new Form4();
            f4.ShowDialog(); // Dùng ShowDialog để bắt buộc xử lý xong Form 4 mới quay lại

            // Khi tắt Form 4, hiện lại Form 3
            this.Show();
        }

        // 2. Xử lý nút Quản lý kho -> Mở Form 5 (Kho và tổng đơn)
        private void btnQLK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            this.Show();
        }

        // 3. Xử lý nút Kiểm kê hàng hóa -> Mở Form 6 (Chi tiết số lượng)
        private void btnKKSL_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
            this.Show();
        }

        // 4. Xử lý nút Thoát -> Quay về Trang chủ
        private void btnOut_Click(object sender, EventArgs e)
        {
            // Hỏi xác nhận trước khi thoát
            DialogResult result = MessageBox.Show("Bạn có muốn quay lại Trang chủ không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng Form3 để quay về Form trước đó (Form 1 hoặc Form 2)
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Có thể thêm code khởi tạo tại đây nếu cần
        }
    }
}