namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            islem o1 = new islem();

            islem2 o2 = new islem2();

            int a=Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            o1.toplama(a, b);
            o1.cikarma(a, b);
            o2.carpma(a, b);
            o2.bolme(a, b);

        }
    }
    class islem
    {
        public void toplama(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void cikarma(int x, int y)
        {
            Console.WriteLine(x - y);
        }
    }

}
