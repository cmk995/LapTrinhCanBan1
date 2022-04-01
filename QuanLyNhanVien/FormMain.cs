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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            NhanVien ti = new NhanVien()
            {
                Id = Guid.NewGuid(),
                FullName = "Ti Tran Van",
                BOD = new DateTime(2000, 1, 1),
                Address = "HCM",
                Email = "titv@gmail.com",
                Phone = "01922323",
                Username = "titv",
                Password = "123456"
            };
            NhanVien teo = new NhanVien()
            {
                Id = Guid.NewGuid(),
                FullName = "Teo Nguyen Van",
                BOD = new DateTime(2000, 1, 1),
                Address = "HCM",
                Email = "teonv@gmail.com",
                Phone = "0900007999",
                Username = "teonv",
                Password = "123456"
            };
            NhanVien.DSNhanVien(ti);
            NhanVien.DSNhanVien(teo);
            // hiện form  đăng nhập
            Form f = new FormDangNhap();
            //DialogResult isLogin = f.ShowDialog();
            var isLogin = f.ShowDialog();
            if (isLogin != DialogResult.OK) {
                // không đăng Nhập
                Close();
            }
            // dang nhap thành công
            lblTaiKhoan.Text =String.Format("Xin Chào: {0}", NhanVien.CurrentUser.FullName);
        }

        private void quảnLýDanhMucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fDanhMuc = new FormDanhMuc();
            fDanhMuc.MdiParent = this;
            fDanhMuc.Show();
        }

        private void lblTaiKhoan_Click(object sender, EventArgs e)
        {
            Form f = new FormProfile();
            f.MdiParent = this;
            f.FormClosed += F_FormClosed;
            f.Show();
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            lblTaiKhoan.Text = String.Format("Xin Chào: {0}", NhanVien.CurrentUser.FullName);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void đọcFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormReadJson();
               
            f.Show();
        }

        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormOpenImages();
            f.Show();
           
        }
    }
}
