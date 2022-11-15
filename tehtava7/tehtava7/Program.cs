using System;

namespace tehtava7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjota kolmion kanta ja korkeus senttimetreina:");
            int kanta = Convert.ToInt32(Console.ReadLine());
            int korkeus = Convert.ToInt32(Console.ReadLine());
            double pintaala = (double)kanta * korkeus / 2;
            Console.WriteLine("Pinta-ala on " + pintaala + "cm^2");
        }
    }
}
