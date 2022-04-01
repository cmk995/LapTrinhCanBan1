using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            Form fDangNhap = new Form1();
           var isLogin = fDangNhap.ShowDialog();
            // dang nhap không thang cong
            // thoát
            if (isLogin != DialogResult.OK) {
                Close(); 
            }
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInput();
                double a = double.Parse(txtSoA.Text.Trim());
                double b = double.Parse(txtSoB.Text.Trim());
                double c = double.Parse(txtSoC.Text.Trim());

                PTB2 phuongTrinhBac2 = new PTB2(a,b,c);
                //phuongTrinhBac2.a = a;
                //phuongTrinhBac2.b = b;
                //phuongTrinhBac2.c = c;
                 
                MessageBox.Show(phuongTrinhBac2.a.ToString());
                //phuongTrinhBac2.GiaiPhuongTrinh();
                //string nghiem = PhuongTrinhBac2(a,b,c);
                string nghiem = phuongTrinhBac2.GiaiPhuongTrinh();
                txtKetQua.Text = nghiem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string PhuongTrinhBac2(double a, double b, double c)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0) {
                return string.Format("PT Vô Nghiệm");
            }
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return string.Format("X1= {0:f2} ,\n X2={1:f2}",x1,x2);

        }

        private void CheckInput()
        {
            #region Kiểm tra đã nhap data chưa
            string soA =  txtSoA.Text.Trim();
            if (soA == "") {
                txtSoA.Focus();
                throw new Exception("Số A Nhập Không Hợp Lệ");
            }
            string soB = txtSoB.Text.Trim();
            if (soB == "")
            {
                txtSoB.Focus();
                throw new Exception("Số B Nhập Không Hợp Lệ");
            }
            string soC = txtSoC.Text.Trim();
            if (soC == "")
            {
                txtSoC.Focus();
                throw new Exception("Số C Nhập Không Hợp Lệ");
            }
            #endregion
            #region Kiem tra nhap có phải là số không
            double a,b,c;
            if (double.TryParse(soA, out a) ==false) {
                txtSoA.Focus();
                txtSoA.SelectAll();
                throw new Exception("Số A Nhập Không Hợp Lệ");
            }
            if (double.TryParse(soB, out b) == false)
            {
                txtSoB.Focus();
                txtSoB.SelectAll();
                throw new Exception("Số B Nhập Không Hợp Lệ");
            }

            if (double.TryParse(soC, out c) == false)
            {
                txtSoC.Focus();
                txtSoC.SelectAll();
                throw new Exception("Số C Nhập Không Hợp Lệ");
            }
            #endregion

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            txtSoC.Text = "";
            txtKetQua.Text = "";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
