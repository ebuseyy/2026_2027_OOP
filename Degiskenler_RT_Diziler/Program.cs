namespace Degiskenler_RT_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi1= { 3, 12, 65, -1000, 4 };

            int[] dizi2 = dizi1;

            dizi1[3] = 1500;

            for (int i = 0; i < dizi2.Length; i++)
                Console.WriteLine($"dizi 2: {dizi2[i]}");
        }
    }
}
