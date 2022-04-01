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
    public partial class FormThemSanPham : Form
    {
        DataBanHangDataContext _db = new DataBanHangDataContext(); //khai báo data context cơ sở dữ liệu
        public FormThemSanPham()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FormThemSanPham_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadNhaCungCap();
        }

        private void LoadNhaCungCap()
        {
            cbbdanhmuc.DataSource = _db.Employees.ToList();
            //var em = new Supplier();
            //em.SupplierID
            cbbnhacc.DisplayMember = "CompanyName";
            cbbnhacc.ValueMember = "SupplierID";

        }

        private void LoadDanhMuc()
        {
            cbbdanhmuc.DataSource =
                 _db.Categories.ToList();
            //Category c = new Category();
            //c.CategoryName
            cbbdanhmuc.DisplayMember = "CategoryID";
            cbbdanhmuc.ValueMember = "CategoryName";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                checkiput();
                Category danhMuc = (Category)cbbdanhmuc.SelectedItem;
                Supplier ncc = (Supplier)cbbdanhmuc.SelectedItem;

                Product sp = new Product()
                {
                    ProductName = txtTen.Text,
                    CategoryID = danhMuc.CategoryID,
                    SupplierID = ncc.SupplierID,
                    //SalePrice = decimal.Parse(txtGiamGia.Text),
                    UnitPrice = decimal.Parse(txtGia.Text),
                    UnitsInStock = short.Parse(txtTonKHo.Text),
                    Discontinued = ccbNgungBan.Checked,
                    UnitsOnOrder = 0,
                    QuantityPerUnit = txtQuycachdonggoi.Text,
                    ReorderLevel = short.Parse(txtSapXep.Text)

                };
                _db.Products.InsertOnSubmit(sp);
                _db.SubmitChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void checkiput()
        {
            if (txtTen.Text.Trim() == string.Empty)
            {
                txtTen.Focus();
                throw new Exception("Ban Chua nhap");
            }
            double a;
            if (double.TryParse(txtGia.Text, out a) == false)
            {
                txtGia.Focus();
                txtGia.SelectAll();
                throw new Exception("Gia Khong Dung Dinh Dang");
            }
            if (double.TryParse(txtGiamGia.Text, out a) == false)
            {
                txtGiamGia.Focus();
                txtGiamGia.SelectAll();
                throw new Exception("Gia Khong Dung Dinh Dang");
            }

        }
    }
}
