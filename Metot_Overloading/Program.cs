namespace Metot_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            metotOL metot = new metotOL();
            metot.topla(5, 6);
            
        }
    }
    class metotOL
    {
        public void topla(int a, int b)
        {
            Console.WriteLine("int topla");
            Console.WriteLine(a + b);
        }
        public void topla(float a, int b)//5,6
        {
            Console.WriteLine("float int topla");
            Console.WriteLine(a + b);
        }
        public void topla(int a, float b)//5,6
        {
            Console.WriteLine(" int float topla");
            Console.WriteLine(a + b);
        }

        public void topla(float a, float b)//5,6
        {
            Console.WriteLine("float float topla");
            Console.WriteLine(a + b);
        }
    }
}

