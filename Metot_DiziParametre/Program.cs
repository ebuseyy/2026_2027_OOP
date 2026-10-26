namespace Metot_DiziParametre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int[] dizi = { 1, 2, 3, 100, 5 };
            MetotDizial metot = new MetotDizial();
            metot.topla(dizi);
            foreach (var sayi in dizi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Toplam: " + toplam);
        }
    }
    class MetotDizial
    {
        public void topla(int[] sayilar)
        {
            
            int toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            Console.WriteLine("Toplam: " + toplam);
            sayilar[3] = 100;
        }
    }
}
