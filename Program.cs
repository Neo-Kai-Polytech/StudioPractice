using System;
using System.CodeDom.Compiler;

namespace Studio_1_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ryan//

            // Data Types
            int sheep, totalSheep;
            string temp;

            // Introduction and Ask for sheep amount
            Console.WriteLine("Hello, my name is Ryan :D");
            Console.WriteLine("How many sheep would you like to count tonight?");
            temp = Console.ReadLine();
            totalSheep = Convert.ToInt32(temp);
            Console.WriteLine("Time to start counting sheep")

            //Count sheep in for loop
            for (int i = 0; i < totalSheep; i++)
            {
                Console.WriteLine($"{i} sheep");
            }
            //Outro
            Console.WriteLine("All sheep have been counted :D");
            Console.ReadLine();


            //Cat//
            Console.WriteLine("Hewo me cat, I go Mrrroooow");
            Thread.Sleep(1000);




            //Alina
            Console.WriteLine("Hi, my name is Alina!")
            Console.WriteLine("I'm 21 years old.");



            //Neo
            Console.WriteLine("This is a line of code that will print a things oh yes it is");
            Console.ReadLine();
        }
    }
}
