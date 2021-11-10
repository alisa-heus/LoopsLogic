using System;
using LoopsLogic;

namespace Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
           
           
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            //int B = Convert.ToInt32(Console.ReadLine());

            int result = Calculator.Fibonacci(7);

            Console.WriteLine(result);  
        }
    }
}
