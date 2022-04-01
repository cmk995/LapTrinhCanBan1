using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangDB
{
    public partial class Form1 : Form
    {
        
        static DataBanHangDataContext _db = new DataBanHangDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _db.Categories.ToList();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Categories
                .Where(
                _cat => _cat.CategoryName.Contains(txtTimKiem.Text)).ToList();
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // check input
                CheckInput();
                _db.Categories.InsertOnSubmit(new Category()
                {
                    CategoryName = txtName.Text,
                    Description = txtMoTa.Text,
                });
                _db.SubmitChanges();

                dataGridView1.DataSource = _db.Categories.ToList();
                SetFormDefaut(new Category());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void SetFormDefaut(Category category)
        {
            txtName.Text = category.CategoryName;
            txtMoTa.Text = category.Description;
            txtMa.Text = category.CategoryID.ToString();
        }

        private void CheckInput()
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                txtName.Focus();
                throw new Exception("Bạn Chưa Nhập Tên Danh Mục");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maDanhMuc = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            string tenDanhMuc = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            string MotaDanhMuc = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            // _SuaCat.CategoryID = int.Parse(maDanhMuc);
            Category.SuaCategory = new Category()
            {
                CategoryID = int.Parse(maDanhMuc),
                CategoryName = tenDanhMuc,
                Description = MotaDanhMuc
            };
            Form f = new FormThemDanhMuc();

            if
                (f.ShowDialog() == DialogResult.OK)
            {
                _db = new DataBanHangDataContext();
                dataGridView1.DataSource =  _db.Categories.ToList();
            }

            
            // 
            //Category cat = new Category()
            //{
            //    CategoryName = tenDanhMuc,
            //    Description = MotaDanhMuc,
            //    CategoryID = int.Parse(maDanhMuc),
            //};
            //SetFormDefaut(cat); 
            SetFormDefaut(new Category()
            {
                CategoryName = tenDanhMuc,
                Description = MotaDanhMuc,
                CategoryID = int.Parse(maDanhMuc),
            });
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Category catDb =
                _db.Categories.FirstOrDefault(cat => cat.CategoryID == int.Parse(txtMa.Text));

            catDb.CategoryName = txtName.Text;
            catDb.CategoryID = int.Parse(txtMa.Text);
            catDb.Description = txtMoTa.Text;
            _db.SubmitChanges(); 
            dataGridView1.DataSource = _db.Categories.ToList();
            SetFormDefaut(new Category());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Category.SuaCategory = null;
            Form f = new FormThemDanhMuc();
            if (f.ShowDialog() == DialogResult.OK) {
                dataGridView1.DataSource = _db.Categories.ToList();
            }
        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void sảmPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormProducts(); //hiển thj form khi click vào
            f.ShowDialog();
        }
    }
}
