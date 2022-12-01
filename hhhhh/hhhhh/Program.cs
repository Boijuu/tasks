using System;
using System.Collections.Generic;

public class HelloWorld

{
    public static void Main(string[] args)
    {
        List<int> numberList = new List<int>();

        numberList.Add(Convert.ToInt32(Console.ReadLine()));
        numberList.Add(Convert.ToInt32(Console.ReadLine()));
        numberList.Add(Convert.ToInt32(Console.ReadLine()));
        numberList.Add(Convert.ToInt32(Console.ReadLine()));
        numberList.Add(Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine("Ensimmainen lista:");

        numberList.ForEach(Console.WriteLine);

        List<int> numbersSquared = new List<int>();

        int index = 0;

        foreach (var i in numberList)
        {
            numbersSquared.Add(numberList[index] * numberList[index]);
            index = index + 1;
        }

        Console.WriteLine("Toinen lista:");

        numbersSquared.ForEach(Console.WriteLine);
    }
}

