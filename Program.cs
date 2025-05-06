namespace Studio_1_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ryan//
            Console.WriteLine("Hello, World!");
            Console.ReadLine();



            //Cat//
            Console.WriteLine("Hewo me cat, I go Mrrroooow");
            Thread.Sleep(1000);




            //Alina




            //Neo
            string temp;
            int high, low;
            high = 100;
            low = 0;

            Console.Write("Enter a number: ");
            temp = Console.ReadLine();
            low = Convert.ToInt32(temp);
            Console.Write("Enter a second number, higher than the first: ");
            temp = Console.ReadLine();
            high = Convert.ToInt32(temp);
            for (int i = 0; i <= high; i++)
            {
                for (int j = low; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine() ;
        }
    }
}
