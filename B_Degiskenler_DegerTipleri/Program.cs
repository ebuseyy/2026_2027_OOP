namespace B_Degiskenler_DegerTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int a = 5;
                int b = a;
                b++;
                Console.WriteLine(a);
                Console.WriteLine(b);

                int* p1 = &a;
                int* p2 = &b;

                Console.WriteLine($"a nın adresi: {(nint)p1}");
                Console.WriteLine($"b nın adresi: {(nint)p2}");

                string adi = "firdevs";
                string soyadi = "ucar";

                string* p3 = &adi;
                string* p4 = &soyadi;

                Console.WriteLine($"adı nın adresi: {(nint)p3}");
                Console.WriteLine($"soyadı nın adresi: {(nint)p4}");
            }

        }
    }
}
