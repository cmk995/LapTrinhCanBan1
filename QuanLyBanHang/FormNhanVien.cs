using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            NhanVien teo = new NhanVien()
            {
                Id = Guid.NewGuid(),
                Name = "Tèo Nguyễn Văn",
                BOD = new DateTime(1990, 1, 1),
                DiaChi = "HCM",
                Email = "teonguyen@gmail.com",
                Phone = "090900001",
                Password = "123456",
                Username = "teonv"
            };
            NhanVien ti = new NhanVien()
            {
                Id = Guid.NewGuid(),
                Name = "Tí Nguyễn Văn",
                BOD = new DateTime(1990, 1, 1),
                DiaChi = "HCM",
                Email = "tinguyen@gmail.com",
                Phone = "090900002",
                Password = "123456",
                Username = "tinv"
            };
            string[] row = {
                ti.Id.ToString(),
                ti.Name,
                ti.BOD.ToString("dd-MM-yyyy"),
                ti.DiaChi,
                ti.Email,
                ti.Phone,
            };
            ListViewItem listViewItem = new ListViewItem(row);
            lsvDanhSachNhanVien.Items.Add(listViewItem);
             
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
