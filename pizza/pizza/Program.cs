using System;

namespace pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pizza on valmis.");
            Console.WriteLine("Kenelle Pizza on?");
            string nimi = Console.ReadLine();
            Console.WriteLine("Kirjataan muistiin. Pizza menee henkilölle " + nimi);
        }
    }
}   

