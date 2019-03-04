using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26122018
{
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil O = new Otomobil(AracTipi.Kara, yakitTuru.Benzin, "Ford",2018,"türkiye",500,"Kırmızı",kasaTipi.Cabrio);
            Ucak u = new Ucak(AracTipi.Hava,ucakTur.Yolcu, yakitTuru.Benzin, "Thy", 2017, "Abd", 100, "Kırmızı", 250);
            Gemi g = new Gemi(AracTipi.Deniz, gemiTur.Savas, yakitTuru.Benzin, "İdo", 2017, "Abd", 100, "Beyaz", 1500);
            // O.DepoDoldur = 40;
            //O.DepoDoldur = 50;
            //  O.Calistir();
            ////  for (int i = 0; i < 10; i++)
            //  {
            //      O.HizArtır();
            //  }
            // O.HizArtır();
            Console.WriteLine(g.ToString());
            
            Console.ReadLine();
        }

    }
    class Arac
    {
        public AracTipi tipi;
        public string model;
        //public string markasi;
        public int yil;
        public string mensei;
        public int beygirGucu;
        public yakitTuru yakitTürü;
        public int Yil
        {
            get { return yil; }

            set
            {
                if (value > 1908 && value <= DateTime.Now.Year)
                {
                    yil = value;
                }
                else
                {
                    Console.WriteLine($"Arac üretim yılı" +
                        $" 1908 yılından küçük ve bulunduğu yıldan büyük olmamalıdır.");
                }
            }
        }
        public AracTipi aracTipi
        {
            get { return tipi; }
            set
            {
                tipi = value;
            }
        }
        public yakitTuru YakitTürü
        {
            get
            {

                return yakitTürü;
            }
            set
            {
                yakitTürü = value;
            }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Mensei { get { return mensei; } set { mensei = value; } }
        public int BeygirGucu
        {
            get
            {

                return beygirGucu;
            }
            set
            {
                if (value > 0 && value < 1000) { beygirGucu = value; }
                else { Console.WriteLine("Beygir Gücü 0 ile 1000 olmalıdır."); }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Arac Modeli : {Model}");
            sb.AppendLine($"Yakit Turu : {YakitTürü}");
            sb.AppendLine($"Arac Yili : {Yil} ");
            sb.AppendLine($"Mensei: {Mensei}");
            sb.AppendLine($"Arac Tipi : {aracTipi} " );
            sb.AppendLine($"Beygir Gücü : {BeygirGucu} ");


            return sb.ToString();
        }
    }

    enum AracTipi
    {
        Kara = 1,
        Deniz = 2,
        Hava = 3
    }
    enum yakitTuru
    {
        Benzin = 1,
        Mazot = 2,
        Elektrik = 3,
        Lpg = 4,
        Nukleer = 5,
        Ruzgar = 6,
        Diger = 7

    }
    enum kasaTipi
    {
        Sedan=1,
        HatchBack=2,
        Station=3,
        Cabrio=4,
        Cupe=5

    }
    class Otomobil : Arac
    {
        bool calistimi = false;
        string renk;
        int kapiSayisi;
        int vitesTipi;
        kasaTipi kasaTipi;
        int depo;
        int hiz;
        public Otomobil(AracTipi aracTipi, yakitTuru yakitTuru, string model, int yil, string mensei, int beygirGucu, string renk,kasaTipi kasaTipi)
        {
            this.aracTipi = aracTipi;
            this.Model = model;
            this.Yil = yil;
            Mensei = mensei;
            BeygirGucu = beygirGucu;
            this.renk = renk;
            this.YakitTürü = yakitTuru;
            this.kasaTipi = kasaTipi;
        }
        public Otomobil() { }
        public int DepoDoldur
        {
            set
            {
                int temp = value + depo;
                if ((temp <= 80 && temp >= 0))
                {
                    depo = value;
                    Console.WriteLine($"Depo şu anda {depo} lt doldu.{value} lt yakıt.alındı");
                }
                else
                {
                    Console.WriteLine("Alinan Yakit depo hacminden fazladir.");
                }
            }

        }
        public Boolean Calistir()
        {
            if (depo > 0)
            {
                calistimi = true;
            }
            return calistimi;
        }
        public Boolean Durdur()
        {
            if (calistimi == true)
            {
                calistimi = false;
                hiz = 0;
            }
            else
            {
                Console.WriteLine("Depo Boş !!!");
            }

            return calistimi;
        }
        public int HizArtır()
        {
            if (calistimi == true)
            {
                hiz += 10;
            }
            else
            {
                Console.WriteLine("Arac Çalışmıyor.");
            }
            return hiz;
        }
        public override string ToString()
        {
            string str = base.ToString();
            str += $"Renk :{renk} \nKasaTipi :{kasaTipi}";
            return str;
        }
        public void Durum()
        {

            string c = calistimi ? "Çalısıyor" : "Calısmiyor";
            Console.WriteLine( $"Arac su anda {c} ve hizi{hiz} km Depoda {depo} lt yakıt var.");
            // Console.WriteLine();
           
        }
    }
    class Ucak : Arac
    {

        int yolcuSayisi;
        ucakTur UcakTur;
        int motorSayisi;
        int hiz;
        string renk;
        public Ucak(AracTipi aracTipi,ucakTur ucakTur, yakitTuru yakitTuru, string model, int yil, string mensei, int beygirGucu, string renk,int yolcuSay)
        {
            this.aracTipi = aracTipi;
            this.UcakTur = ucakTur;
            this.Model = model;
            this.Yil = yil;
            Mensei = mensei;
            BeygirGucu = beygirGucu;
            this.renk = renk;
            this.YakitTürü = yakitTuru;
            yolcuSayisi = yolcuSay;
           
        }
        public override string ToString()
        {
            string str = base.ToString();
            str += $"Renk :{renk} \nYolcu Sayisi : {yolcuSayisi}";
            return str;
        }


    }
    enum ucakTur
    {
        Yolcu=1,
        Savas=2,
        Egitim=3,
        Kargo=4

    }
    enum gemiTur
    {
        Yolcu = 1,
        Savas = 2,
        Egitim = 3,
        Kargo = 4

    }
    class Gemi : Arac
    {
        int yolcuSayisi;
        gemiTur gemiTur;
        int motorSayisi;
        int hiz;
        string renk;
        public Gemi(AracTipi aracTipi, gemiTur gemiTur, yakitTuru yakitTuru, string model, int yil, string mensei, int beygirGucu, string renk, int yolcuSay)
        {
            this.aracTipi = aracTipi;
            this.gemiTur = gemiTur;
            this.Model = model;
            this.Yil = yil;
            Mensei = mensei;
            BeygirGucu = beygirGucu;
            this.renk = renk;
            this.YakitTürü = yakitTuru;
            yolcuSayisi = yolcuSay;

        }
        public override string ToString()
        {
            string str = base.ToString();
            str += $"Renk :{renk} \nYolcu Sayisi : {yolcuSayisi}";
            return str;
        }

    }
}
