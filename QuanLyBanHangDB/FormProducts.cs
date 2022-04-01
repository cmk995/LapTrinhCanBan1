using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangDB
{
    public partial class FormProducts : Form
    {
        DataBanHangDataContext _db = new DataBanHangDataContext();
        public FormProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            dgvDSSP.DataSource = _db.Products.ToList();
            List<Category> dsDanhMuc = _db.Categories.ToList();
            dsDanhMuc.Insert(0, new Category()
                {
                CategoryID = 0,
                CategoryName = "Chon danh muc san pham"
            });

             cbbDanhMuc.DataSource = dsDanhMuc;
            //Category c = new Category();
            //c.CategoryID
            cbbDanhMuc.DisplayMember = "CategoryName";
            cbbDanhMuc.ValueMember = "categoryID";
                
        }

        private void dgvDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tukhoa = txtTuKhoa.Text;
            Category madanhMuc = (Category)
            cbbDanhMuc.SelectedItem;
            //MessageBox.Show("");
            var dsSanPham = _db.Products.Where(sp => sp.CategoryID == madanhMuc.CategoryID
            && sp.ProductName.Contains(tukhoa)).ToList();
            dgvDSSP.DataSource = dsSanPham;
        }

        private void cbbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category danhMuc = (Category)cbbDanhMuc.SelectedItem;
            dgvDSSP.DataSource = _db.Products
                .Where(sp => sp.CategoryID == danhMuc.CategoryID).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form f = new FormThemSanPham(); //hiển thj form khi click vào
            f.ShowDialog();
        }
    }
}
