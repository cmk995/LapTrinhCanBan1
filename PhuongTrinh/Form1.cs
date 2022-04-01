using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhuongTrinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGIai_Click(object sender, EventArgs e)
        {
            // kiểm tra input
            ChekInput();
            double a, b, c;
            double.TryParse(txtSoA.Text,out a);
            double.TryParse(txtSoB.Text, out b);
            double.TryParse(txtSoC.Text, out c);
            txtKetQua.Text = GiaiPhuongTrinhB2(a, b, c);
        }

        private string GiaiPhuongTrinhB2(double a, double b, double c)
        {
            try
            {
                double d = Math.Pow(b, 2) - 4 * a * c;
                if (d < 0)
                {
                    throw new Exception("PT Vo Nghiệm");
                }
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);

                return string.Format("X1={0:F2}, X2={1:F2}",x1,x2);
            }
            catch (Exception ex) 
            {
                return ex.Message;
            }
            
        }

        /// <summary>
        /// kiểm tra input
        /// </summary>
        private void ChekInput()
        {
            try
            {
                if (txtSoA.Text == "")
                {
                    txtSoA.Focus();
                    txtSoA.SelectAll();
                    throw new Exception("Bạn chưa Nhập Số A");
                }
                if (txtSoB.Text == "")
                {
                    txtSoB.Focus();
                    txtSoB.SelectAll();
                    throw new Exception("Bạn chưa Nhập Số B");
                }
                if (txtSoC.Text == "")
                {
                    txtSoC.Focus();
                    txtSoC.SelectAll();
                    throw new Exception("Bạn chưa Nhập Số C");
                }
                double a, b, c;
                if (double.TryParse(txtSoA.Text, out a) ==false){
                    txtSoA.Focus();
                    txtSoA.SelectAll();
                    throw new Exception("So A Không Hợp Lệ");

                }
                if (double.TryParse(txtSoB.Text, out b) == false)
                {
                    txtSoB.Focus();
                    txtSoB.SelectAll();
                    throw new Exception("So B Không Hợp Lệ");

                }
                if (double.TryParse(txtSoC.Text, out c) == false)
                {
                    txtSoC.Focus();
                    txtSoC.SelectAll();
                    throw new Exception("So C Không Hợp Lệ");

                }
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

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            txtSoC.Text = "";
            txtKetQua.Text = "";
        }
    }
}
