using QuanLyBanHang.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += Form4_Load;
            this.btnAddIteam.Click += btnAddIteam_Click;
            this.btnUpIteam.Click += btnUpIteam_Click;
            this.btnDeleteIteam.Click += btnDeleteIteam_Click;
            this.dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            TaiDuLieuLenBang();
        }

        private void TaiDuLieuLenBang()
        {
            try
            {
                dataGridView1.Rows.Clear();
                using (var db = new QuanLyBanHangContext())
                {
                    var listHang = db.MatHangs.ToList();
                    foreach (var item in listHang)
                    {
                        dataGridView1.Rows.Add(item.MaMH, item.TenMH, item.GiaBan, item.SoLuongTon);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        }

        private void btnAddIteam_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new QuanLyBanHangContext())
                {
                    if (db.MatHangs.Any(m => m.MaMH == txtIdIteam.Text))
                    {
                        MessageBox.Show("Mã hàng này đã tồn tại!");
                        return;
                    }

                    MatHang mh = new MatHang()
                    {
                        MaMH = txtIdIteam.Text,
                        TenMH = txtNameIteam.Text,
                        GiaBan = double.Parse(txtGia.Text),
                        SoLuongTon = int.Parse(txtSoLuong.Text),
                        SoLuongHienCo = int.Parse(txtSoLuong.Text),
                        SoLuongDaBan = 0
                    };

                    db.MatHangs.Add(mh);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công!");
                    TaiDuLieuLenBang();
                    ClearFields();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi thêm hàng: " + ex.Message); }
        }

        private void btnUpIteam_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new QuanLyBanHangContext())
                {
                    string id = txtIdIteam.Text;
                    var mh = db.MatHangs.FirstOrDefault(m => m.MaMH == id);
                    if (mh != null)
                    {
                        mh.TenMH = txtNameIteam.Text;
                        mh.GiaBan = double.Parse(txtGia.Text);
                        mh.SoLuongTon = int.Parse(txtSoLuong.Text);
                        mh.SoLuongHienCo = mh.SoLuongTon;

                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!");
                        TaiDuLieuLenBang();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi sửa hàng: " + ex.Message); }
        }

        private void btnDeleteIteam_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtIdIteam.Text;
                using (var db = new QuanLyBanHangContext())
                {
                    var mh = db.MatHangs.FirstOrDefault(m => m.MaMH == id);
                    if (mh != null)
                    {
                        db.MatHangs.Remove(mh);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công!");
                        TaiDuLieuLenBang();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi xóa hàng (Có thể hàng đã bán nên không xóa được): " + ex.Message); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtIdIteam.Text = row.Cells[0].Value?.ToString();
                txtNameIteam.Text = row.Cells[1].Value?.ToString();
                txtGia.Text = row.Cells[2].Value?.ToString();
                txtSoLuong.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void ClearFields()
        {
            txtIdIteam.Clear(); txtNameIteam.Clear(); txtGia.Text = "0"; txtSoLuong.Text = "0";
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
        }
    }
}