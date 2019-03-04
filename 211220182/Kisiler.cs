using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211220182
{
    class Kisiler

    {
        SqlConnection connection;
        SqlCommand cmd;
        string tc = "";
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
        private string _Ad;

        public string Ad
        {
            get { return _Ad; }
            set { _Ad = value; }
        }
        private string _Soyad ;

        public string Soyad
        {
            get { return _Soyad; }
            set { _Soyad = value; }
        }
        private string _Cep;

        public string Cep
        {
            get { return _Cep; }
            set { _Cep = value; }
        }
        
        private string _Tel;

        public string Tel
        {
            get { return _Tel; }
            set { _Tel = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _tc;

        public string Tc
        {
            get { return _tc; }
            set { _tc = value; }
        }

        public Kisiler()
        {
            Ad = "";
            Soyad = "";
            Cep = "";
            Tel = "";
            Email = "";
            Tc = "";
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
                cmd.CommandText = "DKisiEkle";
                cmd.Parameters.AddWithValue("@ad", Ad);
                cmd.Parameters.AddWithValue("@soyad", Soyad);
                cmd.Parameters.AddWithValue("@cep", Cep);
                cmd.Parameters.AddWithValue("@istel", Tel);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@tcNo", Tc);
                cmd.Parameters.AddWithValue("@firmaId", 2);

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
        public List<Kisiler> KisileriVer()
        {
            List<Kisiler> f = new List<Kisiler>();

            connection = new SqlConnection(ConfigurationManager.
                ConnectionStrings["testDb"].ToString());

            cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Kisiler";
            connection.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Kisiler kisiler = new Kisiler();
                kisiler.Ad = rdr["Ad"].ToString();
                kisiler.Soyad = rdr["Soyad"].ToString();
                kisiler.Cep = rdr["Cep"].ToString();
                kisiler.Tel = rdr["istel"].ToString(); ;
                kisiler.Email = rdr["email"].ToString();
               tc=rdr["TcKimlikNo"].ToString();
                if(tc.Length>0)
                kisiler.Tc = tc.Substring(0,3)+"*********";
                else
                {
                    kisiler.Tc = tc;
                }
               // kisiler.Email = rdr["vergiNo"].ToString();
                f.Add(kisiler);
            }


            connection.Close();

            return f;
        }

    }
}
