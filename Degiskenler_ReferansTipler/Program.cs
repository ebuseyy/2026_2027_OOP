namespace Degiskenler_ReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                //string a = "Bilgisayar";
                //string b = a;
                //string c = "Mühendislik";

                //b = "Yazilim";

                //Console.WriteLine(a);
                //Console.WriteLine(b);
                //Console.WriteLine(c);

                //string* p1 = &a;
                //string* p2 = &b;
                //string* p3 = &c;

                //Console.WriteLine($"a nın adresi: {(nint)p1}");
                //Console.WriteLine($"b nın adresi: {(nint)p2}");
                //Console.WriteLine($"c nın adresi: {(nint)p3}");


                Ogrenci Ogr1=new Ogrenci(15,"Ali");
                Ogrenci Ogr2 = Ogr1;

                Ogr1.Adi = "Veli";

                Console.WriteLine($"Birinci: {Ogr1.Adi}");
                Console.WriteLine($"İkinci: {Ogr2.Adi}");
            }

        }
    }
    class Ogrenci
    {
        public int OgrNo;
        public string Adi;

        public Ogrenci(int oNo, string adi)
        {
            OgrNo = oNo;
            Adi = adi;
        }
    }
}
