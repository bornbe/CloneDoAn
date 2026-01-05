using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form5 : Form
    {
        // Khai báo các biến tìm kiếm
        private TextBox txtTimKiem;
        private Label lblTimKiem;

        public Form5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Gán sự kiện
            this.Load += new EventHandler(Form5_Load_1);
            this.dtpChonNgay.ValueChanged += new EventHandler(dtpChonNgay_ValueChanged);

            // Kiểm tra null để tránh lỗi nếu menu chưa được tạo bên Designer
            if (this.TSMIform5 != null)
                this.TSMIform5.Click += new EventHandler(BamNut_LietKeTheoMaDon);

            if (this.liệtKêTheoSốLượngBánRaToolStripMenuItem != null)
                this.liệtKêTheoSốLượngBánRaToolStripMenuItem.Click += new EventHandler(BamNut_LietKeTheoSoLuong);

            if (this.thoátToolStripMenuItem != null)
                this.thoátToolStripMenuItem.Click += new EventHandler(thoátToolStripMenuItem_Click);
        }

        private void Form5_Load_1(object sender, EventArgs e)
        {
            // Cấu hình định dạng ngày tháng
            dtpChonNgay.Format = DateTimePickerFormat.Short;

            // Tạo các control tìm kiếm và cấu hình bảng
            TaoGiaoDienTimKiem();
            CauHinhBang();

            // Tải dữ liệu lần đầu (mặc định sort theo thời gian)
            TaiDuLieuLichSu(0);
        }

        private void TaoGiaoDienTimKiem()
        {
            if (lblTimKiem != null) return; // Nếu đã tạo rồi thì không tạo lại

            lblTimKiem = new Label();
            lblTimKiem.Text = "Tìm kiếm:";
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(dtpChonNgay.Right + 20, dtpChonNgay.Location.Y + 4);
            this.Controls.Add(lblTimKiem);

            txtTimKiem = new TextBox();
            txtTimKiem.Width = 200;
            txtTimKiem.Location = new Point(lblTimKiem.Right + 5, dtpChonNgay.Location.Y);
            // Sự kiện gõ phím để tìm kiếm
            txtTimKiem.TextChanged += (s, args) => TaiDuLieuLichSu(0, txtTimKiem.Text);
            this.Controls.Add(txtTimKiem);
        }

        private void CauHinhBang()
        {
            // Thêm cột Thành Tiền bằng code nếu trong Designer chưa có
            if (dgvCTBH.Columns["colGia"] == null)
            {
                dgvCTBH.Columns.Add("colGia", "Thành Tiền");
            }
            // Định dạng cột tiền có dấu phẩy (VD: 100,000)
            dgvCTBH.Columns["colGia"].DefaultCellStyle.Format = "N0";

            // Định dạng cột ngày giờ cho dễ nhìn
            if (dgvCTBH.Columns[0] != null)
                dgvCTBH.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
        }

        // --- HÀM TẢI DỮ LIỆU CHÍNH ---
        private void TaiDuLieuLichSu(int sortOption, string tuKhoa = "")
        {
            try
            {
                dgvCTBH.Rows.Clear(); // Xóa dữ liệu cũ trên lưới

                // Lấy khoảng thời gian: Từ 00:00 ngày chọn đến 00:00 ngày hôm sau
                DateTime ngayChon = dtpChonNgay.Value.Date;
                DateTime ngayMai = ngayChon.AddDays(1);

                using (var db = new QuanLyBanHangContext())
                {
                    // Query kết hợp 3 bảng: ChiTietDonHang - DonHang - MatHang
                    var query = from ct in db.ChiTietDonHangs
                                join dh in db.DonHangs on ct.MaDH equals dh.MaDH
                                join mh in db.MatHangs on ct.MaMH equals mh.MaMH
                                where dh.NgayBan >= ngayChon && dh.NgayBan < ngayMai
                                select new
                                {
                                    NgayBan = dh.NgayBan,
                                    MaDon = ct.MaDH,        // Mã đơn tự sinh (int)
                                    MaHang = ct.MaMH,
                                    TenHang = mh.TenMH,
                                    SoLuong = ct.SoLuongMua,
                                    ThanhTien = ct.ThanhTien
                                };

                    var listData = query.ToList(); // Lấy dữ liệu về bộ nhớ

                    // 1. Xử lý Tìm kiếm (nếu có từ khóa)
                    if (!string.IsNullOrEmpty(tuKhoa))
                    {
                        string k = tuKhoa.ToLower();
                        listData = listData.Where(x =>
                            x.MaDon.ToString().Contains(k) ||   // Tìm theo mã đơn
                            x.TenHang.ToLower().Contains(k) ||  // Tìm theo tên hàng
                            x.MaHang.ToLower().Contains(k)      // Tìm theo mã hàng
                        ).ToList();
                    }

                    // 2. Xử lý Sắp xếp
                    if (sortOption == 1) // Theo Mã Đơn tăng dần
                    {
                        listData = listData.OrderBy(x => x.MaDon).ToList();
                    }
                    else if (sortOption == 2) // Theo Số Lượng giảm dần
                    {
                        listData = listData.OrderByDescending(x => x.SoLuong).ToList();
                    }
                    else // Mặc định: Mới nhất lên đầu
                    {
                        listData = listData.OrderByDescending(x => x.NgayBan).ToList();
                    }

                    // 3. Hiển thị lên DataGridView
                    foreach (var item in listData)
                    {
                        dgvCTBH.Rows.Add(
                            item.NgayBan.ToString("dd/MM/yyyy HH:mm:ss"), // Cột 1: Date
                            item.MaDon,                                    // Cột 2: IDDon
                            item.MaHang,                                   // Cột 3: IdIteam2
                            item.TenHang,                                  // Cột 4: NameIteam2
                            item.SoLuong,                                  // Cột 5: SoLuong2
                            item.ThanhTien.ToString("N0")                  // Cột 6: Thành Tiền
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu lịch sử: " + ex.Message);
            }
        }

        // --- CÁC SỰ KIỆN ---

        private void dtpChonNgay_ValueChanged(object sender, EventArgs e)
        {
            // Khi chọn ngày mới, xóa ô tìm kiếm và tải lại dữ liệu
            if (txtTimKiem != null) txtTimKiem.Text = "";
            TaiDuLieuLichSu(0);
        }

        private void BamNut_LietKeTheoMaDon(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem != null ? txtTimKiem.Text : "";
            TaiDuLieuLichSu(1, tuKhoa); // 1 = Sort theo Mã
        }

        private void BamNut_LietKeTheoSoLuong(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem != null ? txtTimKiem.Text : "";
            TaiDuLieuLichSu(2, tuKhoa); // 2 = Sort theo Số lượng
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Các hàm auto-generated để trống (giữ lại để tránh lỗi Designer nếu lỡ double click)
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void liệtKêTheoGiáToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void liệtKêTheoSốLượngBánRaToolStripMenuItem_Click(object sender, EventArgs e) { }
    }
}