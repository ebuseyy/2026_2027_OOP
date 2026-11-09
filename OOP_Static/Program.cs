namespace OOP_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            islem o1=new islem();
            o1.degerleriyazdir();
            o1.degerleriarttir();
            o1.degerleriyazdir();
            islem o2 = new islem();
            o2.degerleriyazdir();
            o2.degerleriarttir();
            o2.degerleriyazdir();
        }
    }
    class islem
    {
        static int a;
        int b;
        static islem()
            {
            a = 10;
            }
        public islem()
        {
            a = a+15;
            b++;
        }
        public void degerleriarttir()
        {
            a++;
            b++;
        }
        public void degerleriyazdir()
        {
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
        }
        ~islem()
        {
            Console.WriteLine("Nesne yok ediliyor");
            a--;
            b--;
        }
    }
}
