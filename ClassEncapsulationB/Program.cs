namespace ClassEncapsulationB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w, h;
            Console.WriteLine("Lütfen Genişliği giriniz:");
            w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen .-Uzunluğu giriniz:");
            h = Convert.ToInt32(Console.ReadLine());
            Dortgen dortgen = new Dortgen(w,h);
            dortgen.Weight = -5;
            dortgen.Height = -10;
            dortgen.AlanHesapla();
        }
    }
    class Dortgen
    {
        private int _weight, _height;
        public int Weight { get
            { return _weight; }
            set
            { 
                if(value>0)
                _weight=value; 
            }
        }
        public int Height
        {
            get
            { return _height; }
            set
            {
                if (value > 0)
                    _height = value;
            }
        }
        public Dortgen(int weight, int height)
        {
           Weight = weight;
            Height = height;
        }
        public void AlanHesapla() {
            int sonuc = Weight * Height;
            Console.WriteLine("Sonucumuz: " + sonuc);

        }
    }
}
