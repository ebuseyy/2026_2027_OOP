namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci Ogr=new Ogrenci();
            Ogr.OgrenciNo= 12345678910;
            Ogr.OgrenciBilgileriniGetir();

            Dersler d1 = new Dersler();

        }
    }
    class Ogrenci
    {
        public string Ad;
        public string Soyad;
        private long _OgrenciNo;
        public string Sinif;

        public long OgrenciNo
        {
            get
            {
             return _OgrenciNo;
            }
            set
            {
               if (value.ToString().Length==11 && value>0) 
                    _OgrenciNo=value;
                else
                    Console.WriteLine("Öğrenci numarası 11 haneli olmalıdır.");
            }
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("Öğrenci Adı: " + Ad);
            Console.WriteLine("Öğrenci Soyadı: " + Soyad);
            Console.WriteLine("Öğrenci Numarası: " + OgrenciNo);
            Console.WriteLine("Sınıf: " + Sinif);
        }
    }
    class Dersler
    {
        public string DersAdi;
        public int DersKodu;
        public int DersKredi;
    }
}
