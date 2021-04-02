using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            string[] studentG1 = new string[]
            {
                "Pero",
                "Pero",
                "Pero",
                "Pero",
                "Pero"
            };
            string[] studentG2 = new string[]
            {
                "Blazo",
                "Blazo",
                "Blazo",
                "Blazo",
                "Blazo"
            };

            do
            {
                Console.WriteLine("Enter 1 or 2 to see group of students");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Students in G1 are:");
                        foreach (string item in studentG1)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Students in G2 are");
                        foreach (string item2 in studentG2)
                        {
                            Console.WriteLine(item2);
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }




            } while (false);

            Console.ReadLine();
        }
    }
}
