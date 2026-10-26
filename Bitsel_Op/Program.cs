namespace Bitsel_Op
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte x = 15, y = 254;
            Console.WriteLine(Convert.ToString(x, toBase: 2));
            Console.WriteLine(Convert.ToString(y, toBase: 2));
            var result = x & y;
            Console.WriteLine(result);
            result = result - (x | y);
            Console.WriteLine(--result);
            result = result - (x ^ y);
            Console.WriteLine(result++);
            result = result + x << 2;
            Console.WriteLine("result");
            result = result + x >> 2;
            Console.WriteLine(result);

        }
    }
}
