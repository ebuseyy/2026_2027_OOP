namespace ClassB
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Personel p1=new Personel("Ahmet", "Yılmaz", 1234, "Muhasebe",12345678910);
           // p1.PersonelNo = -5678; // PersonelNo'yu değiştirme
            p1.TC = -123;
            p1.EkranaYaz();
        }
    }
    class Personel
    {
        public string Ad;
        public string Soyad;
        private int PersonelNo;
        public string Departman;
        long _TC;

        public long TC {
            get
            { 
                return _TC; }
            set
            {
                if(value.ToString().Length==11 && value%2==0 && value>0)
                    _TC=value;
                else
                {
                    Console.WriteLine("TC Kimlik Numarası 11 haneli ve çift sayı olmalıdır.");
                }
            }
        }
        public Personel(string ad, string soyad, int personelNo, string departman, long tc)
        {
            Ad = ad;
            Soyad = soyad;
            if (personelNo>0 && personelNo.ToString().Length==6)
            {
                PersonelNo = personelNo;
            }
            else
            {
                Console.WriteLine("Personel numarası 6 haneli ve pozitif olmalıdır.");
            }
            Departman = departman;
            TC = tc;
        }
        public void EkranaYaz()
        {
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Soyad: " + Soyad);
            Console.WriteLine("Personel No: " + PersonelNo);
            Console.WriteLine("Departman: " + Departman);
            Console.WriteLine("TC Kimlik Numarası: " + TC);
        }
    }   
}
