namespace Degiskenler_DegerTipleri
{
    internal class Program
    {

        static void Main(string[] args)
        {
            unsafe
            {
                int a = 5;
                int b = a;
                int c = 0;
                b++;
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                int* p1 = &a;
                int* p2 = &b;
                int* p3 = &c;
                Console.WriteLine($"a nın adresi: {(nint)p1}");
                Console.WriteLine($"b nın adresi: {(nint)p2}");
                Console.WriteLine($"c nın adresi: {(nint)p3}");
            }
        }
    }

}
