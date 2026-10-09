namespace B_Degiskenler_RefTip_Siniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                Personel per1 = new Personel(23, "Elaziz");
                Personel per2 = per1;
                per1.PerAdi = "Van";
                Console.WriteLine(per1.PerAdi);
                Console.WriteLine(per2.PerAdi);
                Personel* p1 = &per1;
                Personel* p2 = &per2;
                Console.WriteLine((nint)p1);
                Console.WriteLine((nint)p2);

            }

        }
    }
    class Personel
    {
        public int PerNo;
        public string PerAdi;
        public Personel(int no, string adi)
        {
            PerNo = no;
            PerAdi = adi;
        }
    }

}
