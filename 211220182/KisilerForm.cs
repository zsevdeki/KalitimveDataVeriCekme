using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211220182
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisiler kisiler = new Kisiler();
            if (txtName.Text != "")
            {
                kisiler.Ad = txtName.Text;
                kisiler.Soyad =txtBxSoyad.Text;
                kisiler.Cep = maskedTxtBxCep.Text;
                kisiler.Tel = maskedTxtBxİs.Text;
                kisiler.Email = txtBxEmail.Text;
                kisiler.Tc = txtBxTc.Text;

                if (kisiler.Ekle() > 0)
                {
                    MessageBox.Show("Eklenmiştir.");
                    //firma.Ekle();
                }
            }
            else
            {
                MessageBox.Show("Firma Adı Boş Bırakalamaz.");
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
       

            Kisiler f = new Kisiler();
            List<Kisiler> kisiler = f.KisileriVer();
            dataGridView1.DataSource = kisiler;
        }
    }
}
