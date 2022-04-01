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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // admin
            // 123456
            try
            {
                string taiKhoan = txtTaiKhoan.Text;
                string matKhau = txtMatKhau.Text;
                if (taiKhoan != "admin" || matKhau != "123456") {
                    throw new Exception("Tài Khoản/ Mật khẩu không hợp lệ");
                }
                //  throw new Exception("Đăng Nhập Thành Công");
                DialogResult = DialogResult.OK;
            }  
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //var kiemTra = MessageBox.Show(
            //    "Bạn có muốn thoát không?",
            //    "Thông Báo",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Warning);
            //if (kiemTra != DialogResult.Yes) {
            //    e.Cancel = true;
            //}

        }
    }
}
