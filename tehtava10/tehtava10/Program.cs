using System;

namespace tehtava10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kohde rivi? ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kohde sarake? ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lahetetaan ritarit.");

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.Beep();

            Console.WriteLine("Ritari yksi kohteeseen (" + x + ", " + (y - 1) + ")");

            Console.WriteLine("Ritari kaksi kohteeseen (" + (x - 1) + ", " + y + ")");

            Console.WriteLine("Ritari kolme kohteeseen (" + x + ", " + (y + 1) + ")");

            Console.WriteLine("Ritari nelja kohteeseen (" + (x + 1) + ", " + y + ")");
        }
    }
}
