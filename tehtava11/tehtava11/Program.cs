using System;

namespace tehtava11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syota numero: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Tick");
            }

            else
            {
                Console.WriteLine("Tock");
            }

        }
    }
}
