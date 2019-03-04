using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211220182
{
    class Urunler
    {
        string constr = "Data Source=SEM-BILGISAYAR;Initial Catalog=test;User ID=test2;Password=test2";
        SqlConnection sqlCon;

        SqlCommand command;
        private bool _hata;
        private string _hataMesaji;

        public string hataMesaji
        {
            get { return _hataMesaji; }
            set { _hataMesaji = value; }
        }

        public  bool hata
        {
            get { return _hata; }
            set { _hata= value; }
        }

        private String _UrunAdi;
        
        public string UrunAdi {
            get { return _UrunAdi; }
            set { _UrunAdi = value; } }
        private string _Barkod;
        public string Barkod {
            get { return _Barkod; }
            set { _Barkod = value; }}
        private int _miktar;
        public int Miktar
        {
            get { return _miktar; }
            set {

                if (value <= 0)
                {
                    _hata = true;
                    _hataMesaji = "Ürün miktari 0'dan büyük olması gerekir.";
                }

                _miktar = value; }
        }
        private int _birim;
        public int Birim
        {
            get { return _birim; }
            set { _birim = value; }
        }
        private DateTime _rafOmru;
        public DateTime rafOmru
        {
            get { return _rafOmru; }
            set { _rafOmru = value; }
        }
        private string _mensei;
        public string Mensei

            
        {
            get { return _mensei; }
            set { _mensei = value; }
        }
        public Urunler()
        {
            UrunAdi = "";
            Barkod = "";
            Miktar = 0;
            Birim = 1;
            rafOmru = DateTime.Now.AddMonths(12);
            Mensei = "";
        }

        public int Ekle() {

            int sonuc = 0;
            try
            {
                sqlCon = new SqlConnection(constr);
                command = new SqlCommand();
                command.Connection = sqlCon;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "InsertUrunProcedures";
                command.Parameters.AddWithValue("@urunAdi", _UrunAdi);
                command.Parameters.AddWithValue("@barkod", _Barkod);
                command.Parameters.AddWithValue("@miktar", _miktar);
                command.Parameters.AddWithValue("@birim", _birim);
                command.Parameters.AddWithValue("@RafOmru", _rafOmru);
                command.Parameters.AddWithValue("@mensei", _mensei);

                sqlCon.Open();
                sonuc = command.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception ex)
            {

                _hata = true;
                _hataMesaji = ex.Message;
            }
               

            return sonuc;
        }
    }
}
