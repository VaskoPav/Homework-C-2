using System;

namespace Homework_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] userInputNumbers = new int[6];
            int sumEvenNumbers = 0;

            for (int i = 0; i < userInputNumbers.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                userInputNumbers[i] = int.Parse(Console.ReadLine());
                if (userInputNumbers[i] % 2 == 0)
                {
                    sumEvenNumbers += userInputNumbers[i];

                }
                else
                {
                    Console.WriteLine("This is odd number: " + userInputNumbers[i]);
                }
                
            }
            Console.WriteLine("The sum of even number is: " + sumEvenNumbers);

            // 4,3,7,3,2,8

            Console.ReadLine();
        }
    }
}
