using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace _211220182
{
    class Firma
    {
        SqlConnection connection;
        SqlCommand cmd;
        
        private bool _hatavar;

        public bool HataVar
        {
            get { return _hatavar; }
            set { _hatavar = value; }
        }
        private string _hataMesaji;

        public string HataMesaji
        {
            get { return _hataMesaji; }
            set { _hataMesaji = value; }
        }



        private string _unvan;

        public string Unvan
        {
            get { return _unvan; }

            set { _unvan = value; }
        }
        private int _firmaTipi;

        public int FirmaTipi
        {
            get { return _firmaTipi; }
            set { _firmaTipi = value; }
        }

        private string _adres1;

        public string Adres1
        {
            get { return _adres1; }
            set { _adres1 = value; }
        }
        private string _adres2;

        public string Adres2
        {
            get { return _adres2; }
            set { _adres2 = value; }
        }
        private string _vergiDairesi;

        public string VergiDairesi
        {
            get { return _vergiDairesi; }
            set { _vergiDairesi = value; }
        }

        private string _vergiNumarasi;

        public string VergiNumarasi
        {
            get { return _vergiNumarasi; }
            set { _vergiNumarasi = value; }
        }

        public Firma()
        {
            Unvan = "";
            FirmaTipi = 0;
            Adres1 = "";
            Adres2 = "";
            VergiDairesi = "Yok";
            VergiNumarasi = "";
        }
        public int Ekle()
        {
            int sonuc = 0;
            try
            {
                connection = new SqlConnection
                    (ConfigurationManager.ConnectionStrings["testDb"].ConnectionString);
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                //düzenleme yapılmıstır.
                cmd.CommandText = "DFirmaEkle";
                cmd.Parameters.AddWithValue("@firmaAdi", Unvan);
                cmd.Parameters.AddWithValue("@firmaTipi", FirmaTipi);
                cmd.Parameters.AddWithValue("@Adres1", Adres1);
                cmd.Parameters.AddWithValue("@Adres2", Adres2);
                cmd.Parameters.AddWithValue("@VergiD", VergiDairesi);
                cmd.Parameters.AddWithValue("@VergiNumarasi", VergiNumarasi);

                connection.Open();

                sonuc = cmd.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception ex)
            {

                HataVar = true;
                _hataMesaji = ex.Message;
                throw;
            }
            finally
            {
                connection.Close();
            }
            return sonuc;
        }
        public List<Firma> FirmalariVer()
        {
            List<Firma> f = new List<Firma>();

            connection = new SqlConnection(ConfigurationManager.
                ConnectionStrings["testDb"].ToString());

            cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from firma";
            connection.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Firma firma = new Firma();
                firma.Unvan = rdr["Unvani"].ToString();
                firma.Adres1 = rdr["Adres1"].ToString();
                firma.Adres2 = rdr["Adres2"].ToString();
                firma.FirmaTipi = Int32.Parse(rdr["FirmaTipi"].ToString());
                firma.VergiDairesi = rdr["vergiDairesi"].ToString();
                firma.VergiNumarasi = rdr["vergiNo"].ToString();
                f.Add(firma);
            }


            connection.Close();

            return f;
        }

    }
}
