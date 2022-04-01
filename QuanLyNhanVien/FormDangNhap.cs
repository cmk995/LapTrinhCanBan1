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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              new NhanVien();
               NhanVien nv = NhanVien.TimNhanVien(txtTaiKhoan.Text, txtMatKhau.Text); 
                if (nv.Username==null) {
                    throw new Exception("Tài khoản/ mật khẩu không đúng");
                }
                // lưu danh tính Người đang Đăng Nhap
                NhanVien.CurrentUser = nv;
                // có tài khoản mât khẩu
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            { 
                lblLoi.Text = ex.Message;
                txtTaiKhoan.Focus();
                txtTaiKhoan.SelectAll();
                errorProvider1.SetError(txtTaiKhoan, ex.Message);
            }
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
