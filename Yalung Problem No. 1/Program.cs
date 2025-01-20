using System.Reflection.PortableExecutable;

namespace Yalung_Problem_No._1
{
    internal class Program
    {
        
        static void Main()
        {
            FizzBuzzProgram();                          // para ma call yung function na FizzBuzzProgram
        }
        
        static void FizzBuzzProgram()
        {
            Console.WriteLine("This is my FizzBuzz Program. \n");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3  == 0 && i % 5 ==0)           // checks if divisible by 3 and 5
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 ==0)                     // checks if divisible by 3
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 ==0)                     // checks if divisible by 5
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);               // prints the next number if not divisible by 3 or 5
                }
            }
        }
    }
}
