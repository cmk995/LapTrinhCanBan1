using Newtonsoft.Json;
using QuanLyNhanVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class FormReadJson : Form
    {
        public FormReadJson()
        {
            InitializeComponent();
        }

        private async void FormReadJson_LoadAsync(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("ss:HH dd-MM-yyyy");
            timer1.Start();
            User u = new User();
           string jsonContent = await u.GetUsersAsync();
            txtNoiDung.Text = jsonContent;
            List<User> dsUsers =
                   JsonConvert
                   .DeserializeObject<List<User>>(jsonContent);
            dgvDsNhanVien.DataSource = dsUsers.ToList();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {



            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                //MessageBox.Show(openFileDialog1.FileName);
                string Content = File.ReadAllText(openFileDialog1.FileName);
                //MessageBox.Show(Content);
                txtNoiDung.Text = Content;
              List<NhanVien> dsNhanVien =
                    JsonConvert.DeserializeObject<List<NhanVien>>(Content);
                dgvDsNhanVien.DataSource = dsNhanVien.ToList();

            }
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string pathFileSave = saveFileDialog1.FileName;
                File.WriteAllText(pathFileSave, txtNoiDung.Text);

            } 


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("ss:HH dd-MM-yyyy");
        }
    }
}
