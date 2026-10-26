namespace Metot_ParamsDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            metot_Params metot = new metot_Params();
            metot.topla(4,5,4,5);
        }
    }
    class metot_Params
    {
        public void topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            Console.WriteLine("Toplam: " + toplam);
        }
        public void topla(params float[] sayilar)
        {
            float toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            Console.WriteLine("Toplam: " + toplam);
        }
    }
}
