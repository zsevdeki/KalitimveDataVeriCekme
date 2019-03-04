using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _211220182
{
    public partial class Form1 : Form
    {
        

      
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e) {
            
            Urunler u = new Urunler();
            u.UrunAdi = txtName.Text;
            u.Barkod = txtBarkod.Text;
            u.Miktar = Int32.Parse(txtMiktar.Text);
            u.Birim = Int32.Parse(txtBirim.Text);
            u.rafOmru = DateTime.Now.AddMonths(12);
            u.Mensei = txtMensei.Text;
            u.Ekle();
            if (u.hata == false)
            {
                MessageBox.Show("Alinan Hata : " + u.hataMesaji);
            }
            else
            {
                MessageBox.Show("Kayit Eklenmiştir.");
            }
        }
    }
}
