namespace ClassEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Genişliği giriniz: ");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Uzunluğu giriniz: ");
            int h = Convert.ToInt32(Console.ReadLine());

            Dortgen d1 = new Dortgen(w, h);
            d1.AlanHesapla();
        }
    }
    class Dortgen
    {
        public int Weight
        {
            get;
            set;
        }
        public int Height { get; set; }

        public Dortgen(int weight, int height)
        {
            if (weight > 0 && height > 0)
            {
                Weight = weight;
                Height = height;
            }
            else
            {
                Weight = 0;
                Height = 0;
            }

        }
        public void AlanHesapla()
        {
            float sonuc = Weight * Height;
            Console.WriteLine("Dörtgenin Alanı: " + sonuc);
        }
    }
}
