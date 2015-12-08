using System;
namespace Lab1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hi there!");
            Console.WriteLine("Skriva ut olika värden {0} och {1} och {0} igen", 5, 8);
            Console.WriteLine("Skriva ut ett siffra som ett pengavärde t ex {0:c}", 1000);
            Console.WriteLine("Placerar text lite till höger {0,10} och sätter decimal till 2 st {0:f2}", 20.4587);
            
            Console.ReadLine();
        }
    }
}
