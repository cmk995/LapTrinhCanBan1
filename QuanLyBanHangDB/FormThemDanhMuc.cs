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
    public partial class FormThemDanhMuc : Form
    {
        DataBanHangDataContext _db = new DataBanHangDataContext();

        public FormThemDanhMuc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInput();
                Category cat = new Category() {
                    CategoryID = int.Parse(txtMa.Text),
                    CategoryName = txtName.Text,
                    Description= txtMoTa.Text
                };
                _db.Categories.InsertOnSubmit(cat);
                _db.SubmitChanges();
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckInput()
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                txtName.Focus();
                throw new Exception("Bạn Chưa Nhập Tên Danh Mục");
            }
        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormThemDanhMuc_Load(object sender, EventArgs e)
        {
            if (Category.SuaCategory == null)
            {
                // thêm
                Category.SuaCategory = new Category();

            }
            else
            {
                // sửa
                btnSua.Enabled = true;
                button2.Enabled = false;
            }
            var Cat = Category.SuaCategory;
            txtMa.Text = Cat.CategoryID.ToString();
            txtName.Text = Cat.CategoryName;
            txtMoTa.Text = Cat.Description;


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Category catDb =
                _db.Categories.FirstOrDefault(cat => cat.CategoryID == int.Parse(txtMa.Text));

            catDb.CategoryName = txtName.Text;
            catDb.CategoryID = int.Parse(txtMa.Text);
            catDb.Description = txtMoTa.Text;
            _db.SubmitChanges();
            //đóng form
            DialogResult = DialogResult.OK;
        }
    }
}
