using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace _211220182
{
    public partial class FirmaForm : Form
    {
        public FirmaForm()
        {
            InitializeComponent();
          //  FirmaForm.ActiveForm.Text = ConfigurationManager.AppSettings["ProgramAdi"].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Firma firma = new Firma();
            if (txtBxFirmaAdi.Text != "")
            {
                firma.Unvan = txtBxFirmaAdi.Text;
                firma.FirmaTipi = cmBxFirmaTipi.SelectedIndex + 1;
                firma.Adres1 = textBox2.Text;
                firma.Adres2 = textBox3.Text;
                firma.VergiDairesi = txtBxVergiD.Text;
                firma.VergiNumarasi = txtBxVNo.Text;

                if (firma.Ekle() > 0)
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
        public void ekraniTemizle()
        {
            TextBox textBox = new TextBox();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Firma f = new Firma();
            List<Firma> firmalar = f.FirmalariVer();
            dataGridViewFirma.DataSource = firmalar;
        }
    }
}
