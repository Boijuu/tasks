using System;

namespace The_robot_namer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of robot are we talking about?");
            string a = Console.ReadLine(); // tämä muuttuja sisältää merkkijonon joka printataan viimeisessä osassa koodia
            Console.WriteLine("how would you describe it?");
            string b = Console.ReadLine(); // tämä muuttuja sisältää merkkijonon joka printataan viimeisessä osassa koodia
            string c = "Of destruction";  // tämä muuttuja sisältää merkkijonon joka printataan viimeisessä osassa koodia
            string d = "5000"; // tämä muuttuja sisältää merkkijonon joka printataan viimeisessä osassa koodia 
            Console.WriteLine("the " + b + " " + a + " Bot " + c + " " + d + "!"); 
        }

    }
}
