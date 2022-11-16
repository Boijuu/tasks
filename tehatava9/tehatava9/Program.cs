using System;

namespace tehatava9
{
    class Program
    {
        static void Main(string[] args)
        {
            int lopputulos = 0;
            string tyyppi;
            int maara;

            Console.WriteLine("Kirjoita tyyppi (maatila, herttuakunta, maakunta) ja sitten maara, jata tyhjaksi kun haluat poistua:");

            while (true)
            {
                tyyppi = Console.ReadLine();

                if (tyyppi == "")
                {
                    break;
                }

                maara = Convert.ToInt32(Console.ReadLine());

                if (tyyppi == "maatila")
                {
                    lopputulos = lopputulos + maara;
                }

                if (tyyppi == "herttuakunta")
                {
                    lopputulos = lopputulos + (maara * 3);
                }

                if (tyyppi == "maakunta")
                {
                    lopputulos = lopputulos + (maara * 6);
                }
            }
            Console.WriteLine("Pelaajan pisteet on " + lopputulos);
        }
    }
}
