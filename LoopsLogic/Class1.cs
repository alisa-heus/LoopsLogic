using System;
using System.Collections.Generic;

namespace LoopsLogic
{
    public class Calculator
    {
        public static int AtoPowerB(int A, int B)
        {
            
            for (int i = 1; i < B; i++)
            {
                A *= A;
            }
            return A;
        }

        public static List<int> DivisibleByA(int A)
        {
            List<int> result = new List<int>();
            for (int i = 1; i < 1000; i++)
            {
                if (i%A == 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static int PositiveFullNumberCounter(int A)
        {
            int count = 0;
            for (int i = 1; i < A; i++)
            {
                if(i*i < A)
                {
                    count++;
                }
                
            }
            return count;
        }

        public static int LargestDivisor(int A)
        {
            int divisor = 1;
            for (int i = 1; i < A; i++)
            {
                if (A% i == 0)
                {
                    divisor=i;
                }
            }
            return divisor;
        }

        public static int SumOfNumbers(int A, int B)
        {
            if (B<A) 
            {
                int temp = A;
                A = B;
                B = temp;
            }
            int sum = 0;
            for (int i = A; i <= B; i++)
            {
                if (i % 7 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

       public static int Fibonacci(int N)
        {
            int a = 1;
            int b = 1;
            int res = 0;

            for(int i = 2; i<N; i++)
            {
                res = a + b;
                a = b;
                b = res;
            }
            return res;
        }
        


    }
}
