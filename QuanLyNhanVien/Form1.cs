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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //NhanVien ti = new NhanVien()
            //{
            //    Id = Guid.NewGuid(),
            //    FullName = "Ti Tran Van",
            //    BOD = new DateTime(2000, 1, 1),
            //    Address = "HCM",
            //    Email = "titv@gmail.com",
            //    Phone = "01922323",
            //    Username = "titv",
            //    Password = "123456"
            //};
            //NhanVien teo = new NhanVien()
            //{
            //    Id = Guid.NewGuid(),
            //    FullName = "Teo Nguyen Van",
            //    BOD = new DateTime(2000, 1, 1),
            //    Address = "HCM",
            //    Email = "teonv@gmail.com",
            //    Phone = "0900007999",
            //    Username = "teonv",
            //    Password = "123456"
            //};
            ////List<NhanVien> dsNhanVien = new List<NhanVien>();
            ////dsNhanVien.Add(ti);
            ////dsNhanVien.Add(teo);
            //NhanVien.DSNhanVien(ti);
            //NhanVien.DSNhanVien(teo);
            dgvDSNhanVien.DataSource = NhanVien.DSNhanVien().ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {  
                NhanVien nv = CheckInput();
                NhanVien.DSNhanVien(nv);
               // MessageBox.Show(nv.Id.ToString()); 
                dgvDSNhanVien.DataSource = NhanVien.DSNhanVien().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
        /// <summary>
        /// kiem tra data 
        /// </summary>
        private NhanVien CheckInput()
        {

            if (txtHoTen.Text == "")
            {
                txtHoTen.Focus();
                throw new Exception("Bạn Chưa Nhập Họ Tên");
            }
            if (txtEmail.Text == "")
            {
                txtEmail.Focus();
                throw new Exception("Bạn Chưa Nhập Email");
            }
            if (txtSDT.Text == "")
            {
                txtSDT.Focus();
                throw new Exception("Bạn Chưa Nhập SĐT");
            }
            if (txtDiaChi.Text == "")
            {
                txtDiaChi.Focus();
                throw new Exception("Bạn Chưa Nhập Địa Chỉ");
            }
            if (txtTaiKhoan.Text == "")
            {
                txtTaiKhoan.Focus();
                throw new Exception("Bạn Chưa Nhập Tài Khoản");
            }
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Focus();
                throw new Exception("Bạn Chưa Nhập Mật Khẩu");
            }

            NhanVien nv = new NhanVien()
            {
                FullName = txtHoTen.Text,
                Phone = txtSDT.Text,
                Address = txtDiaChi.Text,
                BOD = dtpNgaySinh.Value,
                Email = txtEmail.Text,
                Password = txtMatKhau.Text,
                Username = txtTaiKhoan.Text,
                Id = Guid.NewGuid()
            };
            return nv; 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
