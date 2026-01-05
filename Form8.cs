using QuanLyBanHang.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += Form8_Load;
            this.timer1.Tick += Timer1_Tick;
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; 
            timer1.Start();
            if (SessionData.GioHang != null && SessionData.GioHang.Count > 0)
            {
                dataGridViewThanhtoan.Rows.Clear();
                foreach (var item in SessionData.GioHang)
                {
                    dataGridViewThanhtoan.Rows.Add(
                        item.MaMH,
                        item.TenMH,
                        item.SoLuong,
                        item.DonGia,
                        item.ThanhTien
                    );
                }
                TinhTongTien();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (statusStrip1.Items.Count > 0)
            {
                statusStrip1.Items[0].Text = "Thời gian hiện tại: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }

        private void btnthemhangthanhtoan_Click_1(object sender, EventArgs e)
        {
            txtmonhangthanhtoan.ReadOnly = false;
            string maMH = txtmonhangthanhtoan.Text.Trim();
            int soLuongMua;

            if (string.IsNullOrEmpty(maMH))
            {
                MessageBox.Show("Vui lòng nhập mã hàng!");
                return;
            }
            if (!int.TryParse(txtsoluongthanhtoan.Text, out soLuongMua) || soLuongMua <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên lớn hơn 0!");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewThanhtoan.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maMH)
                {
                    MessageBox.Show("Mã hàng này đã có trong giỏ! Vui lòng chọn dòng đó và nhấn nút 'Sửa' để cập nhật số lượng.");
                    return;
                }
            }
            using (var db = new QuanLyBanHangContext())
            {
                var mh = db.MatHangs.FirstOrDefault(m => m.MaMH == maMH);
                if (mh != null)
                {
                    double thanhTien = soLuongMua * mh.GiaBan;
                    dataGridViewThanhtoan.Rows.Add(mh.MaMH, mh.TenMH, soLuongMua, mh.GiaBan, thanhTien);
                    TinhTongTien();
                    ResetInput();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã hàng này trong kho!");
                }
            }
        }

        private void btnsuahangthanhtoan_Click(object sender, EventArgs e)
        {
            if (dataGridViewThanhtoan.CurrentRow == null || dataGridViewThanhtoan.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng click chọn một dòng hàng trong bảng danh sách bên phải trước!");
                return;
            }

            int soLuongMoi;
            if (!int.TryParse(txtsoluongthanhtoan.Text, out soLuongMoi) || soLuongMoi <= 0)
            {
                MessageBox.Show("Số lượng sửa phải lớn hơn 0!");
                return;
            }

            DataGridViewRow row = dataGridViewThanhtoan.CurrentRow;
            double giaBan = double.Parse(row.Cells[3].Value.ToString());
            row.Cells[2].Value = soLuongMoi;
            row.Cells[4].Value = soLuongMoi * giaBan;

            TinhTongTien();
            MessageBox.Show("Đã cập nhật số lượng thành công!");
            ResetInput();
        }

        private void btnxoahangthanhtoan_Click(object sender, EventArgs e)
        {
            if (dataGridViewThanhtoan.CurrentRow == null || dataGridViewThanhtoan.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa khỏi giỏ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridViewThanhtoan.Rows.Remove(dataGridViewThanhtoan.CurrentRow);
                TinhTongTien();
                ResetInput();
            }
        }
        private void btnhoantatthanhtoan_Click(object sender, EventArgs e)
        {
            bool coHang = false;
            foreach (DataGridViewRow r in dataGridViewThanhtoan.Rows)
            {
                if (!r.IsNewRow && r.Cells[0].Value != null)
                {
                    coHang = true;
                    break;
                }
            }

            if (!coHang)
            {
                MessageBox.Show("Giỏ hàng đang trống! Vui lòng thêm sản phẩm trước khi thanh toán.");
                return;
            }
            SessionData.GioHang.Clear();

            foreach (DataGridViewRow row in dataGridViewThanhtoan.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value != null)
                {
                    SessionData.GioHang.Add(new CartItem()
                    {
                        MaMH = row.Cells[0].Value.ToString(),
                        TenMH = row.Cells[1].Value.ToString(),
                        SoLuong = int.Parse(row.Cells[2].Value.ToString()),
                        DonGia = double.Parse(row.Cells[3].Value.ToString()),
                        ThanhTien = double.Parse(row.Cells[4].Value.ToString())
                    });
                }
            }
            SessionData.TongTien = SessionData.GioHang.Sum(x => x.ThanhTien);
            Form9 f9 = new Form9(this);
            f9.Show();
            this.Hide();
        }
        private void TinhTongTien()
        {
            double tong = 0;
            foreach (DataGridViewRow row in dataGridViewThanhtoan.Rows)
            {
                if (!row.IsNewRow && row.Cells[4].Value != null)
                {
                    tong += double.Parse(row.Cells[4].Value.ToString());
                }
            }
            txtTongGiathanhtoan.Text = tong.ToString("N0");
        }

        private void ResetInput()
        {
            txtmonhangthanhtoan.Text = "";
            txtsoluongthanhtoan.Text = "0";
            txtmonhangthanhtoan.ReadOnly = false;
        }

        private void btnvetrangchinh_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void dataGridViewThanhtoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dataGridViewThanhtoan.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow row = dataGridViewThanhtoan.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    txtmonhangthanhtoan.Text = row.Cells[0].Value.ToString();
                    txtsoluongthanhtoan.Text = row.Cells[2].Value.ToString();
                    txtmonhangthanhtoan.ReadOnly = true; 
                }
            }
        }
    }
}