using System;

namespace Studio_1_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ryan//
            Console.WriteLine("Hello, my name is Ryan :D");
            Console.ReadLine();


            //Cat//
            int bike = 0;
            Console.WriteLine("Hewo me Cat, I go Mrrroooow");
            for (int i = 0; i < 11; i++)
            {
                bike++;
                if (bike == 1)
                {
                    Console.WriteLine($"You own {bike} motorbike, that's a bit drab.");
                }
                else if(bike == 2)
                {
                    Console.WriteLine($"You own {bike} motorbikes! That's better! More fun huh?");
                }
                else if (bike == 3)
                {
                    Console.WriteLine($"You own {bike} motorbikes! Woah slow down!");
                }
                else if (bike == 4)
                {
                    Console.WriteLine($"You own {bike} motorbikes! Ok I give up!");
                }
                else
                {
                    Console.WriteLine($"You own {bike} motorbikes.....");
                }
                Thread.Sleep(300);
            }




            //Alina
            Console.WriteLine("Hi, my name is Alina!");
            Console.WriteLine("I'm 21 years old.");
            int banana = 0;
            for (int i = 0; i < 10; i++)
            {
                banana++;
                Console.WriteLine("Iteration " + i + " : " + banana + " bananas");
            }

            Console.WriteLine("Total: " + banana + " bananas");




            //Neo
            Console.WriteLine("This is a line of code that will print a things oh yes it is");
            Console.ReadLine();
        }
        
    }
}
