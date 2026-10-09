namespace B_Defiskenler_RefTip_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int[] dizi1 = { 100, 200, 300 };
                int[] dizi2 = dizi1;

                dizi2[1] = -1000;

                for (int i = 0; i < dizi1.Length; i++)
                {
                    Console.WriteLine(dizi1[i]);
                }

                ///int* p1 = &dizi1[0];

                
                fixed (int* p1 = dizi1)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine((nint)(p1 + i));
                    }
                }

          
            }
        }
    }
}
