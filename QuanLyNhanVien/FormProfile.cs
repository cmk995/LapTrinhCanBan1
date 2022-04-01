using QuanLyNhanVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cap nhat mat khẩu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text) {
                    txtMatKhauMoi.Focus();
                    txtMatKhauMoi.SelectAll();
                    throw new Exception("Mật khẩu mới không khớp"); 
                }
                if (NhanVien.CurrentUser.Password != txtMatKhauCu.Text) 
                {
                    throw new Exception("Mật khẩu cũ không đúng");
                }
                // nhap đúng mật khẩu 
                // mật khẩu mới hop lệ

                NhanVien.CurrentUser.Password = txtMatKhauMoi.Text;
                MessageBox.Show("Đã cập nhật mật khẩu", "Thàng công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }


        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            NhanVien nv = NhanVien.CurrentUser;
            txtHoTen.Text = nv.FullName;
            txtDiaChi.Text = nv.Address;
            txtEmail.Text = nv.Email;
            txtSDT.Text = nv.Phone;
            dtpNgaySinh.Value = nv.BOD;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // lưu thông tin đăng nhập hiện tai
            NhanVien.CurrentUser.FullName = txtHoTen.Text;
            NhanVien.CurrentUser.Phone = txtSDT.Text;
            NhanVien.CurrentUser.Email = txtEmail.Text;
            NhanVien.CurrentUser.Address = txtDiaChi.Text;
            NhanVien.CurrentUser.BOD = dtpNgaySinh.Value;
            MessageBox.Show("Lưu Thông Tin Thành Công", "Thông Báo");
            DialogResult = DialogResult.OK;
        }
    }
}
