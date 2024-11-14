using System;
namespace Upgift3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej. Vill du hyra bilen?");
            Console.WriteLine("J för ja och N for Nej");
            string A = Console.ReadLine().ToLower();
            if (A == "j")
            {
                Console.WriteLine("Hur många heltimmar skulle du velja bästella?");
                Console.WriteLine("Det kostar 80 kr i timmen max timmar man kan köpa är 11");
                int B = int.Parse(Console.ReadLine());
                int c = 80 * B;
                Console.WriteLine("det kommer att kosta dig" + " " + c + " " + "kr");
            }

            else
            {
                Console.WriteLine("okej hej då");
                Console.ReadKey();
            }

        }
    }
}