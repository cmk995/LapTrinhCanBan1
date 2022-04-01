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
    public partial class FormDanhMuc : Form
    {
        public FormDanhMuc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DanhMuc dm = CheckInput();
                DanhMuc.ThemDanhMuc(dm);
                dgvDanhMuc.DataSource = DanhMuc.GetDanhMuc().ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private DanhMuc CheckInput()
        {
            if (txtCode.Text == "")
            {
                txtCode.Focus();
                throw new Exception("Bạn chưa nhập Mã DM");
            }
            if (txtName.Text == "")
            {
                txtName.Focus();
                throw new Exception("Bạn chưa nhập Tên DM");
            }
            return new DanhMuc()
            {
                Id= Guid.NewGuid(),
                Code = txtCode.Text,
                Name = txtName.Text,
                Decription = txtDecription.Text
            };
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            DanhMuc.ThemDanhMuc(new DanhMuc()
            {
                Id= Guid.NewGuid(),
                Code = "DM001",
                Name = "Áo Thun",
                Decription = "",
            });
            DanhMuc.ThemDanhMuc(new DanhMuc()
            {
                Id = Guid.NewGuid(),
                Code = "DM002",
                Name = "Áo Khoác",
                Decription = "",
            });
            dgvDanhMuc.DataSource = DanhMuc.GetDanhMuc().ToList();
        }
    }
}
