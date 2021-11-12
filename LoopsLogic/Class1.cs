using System;
using System.Collections.Generic;

namespace LoopsLogic
{
    public class Calculator
    {
        public static int AtoPowerB(int A, int B)
        {
            int res = 1;
            for (int i = 1; i < B; i++)
            {
                res = res * A;
            }
            return res;
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

        public static int GetCommonDivisor(int A, int B)
        {
            if (B>A)
            {
                Swap(ref A, ref B);
            }
            int result = 0;
            int remainder = 0;
            do
            {
                result = B;
                remainder = A % B;
                A = B;
                B = remainder;
            } while (remainder != 0);

            return result;
        }

        public static int CountOdds(string number)
        {
            int count = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (Convert.ToInt32(number[i])%2 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int ReverseNumber(string number)
        {
            string result = "";
            for (int i = number.Length-1; i >= 0; i--)
            {
                result += number[i];
            }
            return Convert.ToInt32(result);      
        }

        public static int[] CheckNumbersInRange(string N)
        {
            int n = Convert.ToInt32(N);
            int[] temp = new int[n];
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
               if (IsEvensSumGreaterThanOddsSum(i))
               {
                    temp[count] = i;
                    count++;
               }   
            }

            int[] result = new int[count];
            for(int i = 0; i < count; i++)
            {
                result[i] = temp[i];
            }

            return result;
        }

        public static bool CompareDigits(string A, string B)
        {
            foreach (int digitA in A)
            {
                foreach (int digitB in B)
                {
                    if (digitA == digitB)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static bool IsEvensSumGreaterThanOddsSum(int num)
        {
            string number = num.ToString();
            int evensSum = 0;
            int oddsSum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (Convert.ToInt32(number[i]) % 2 != 0)
                {
                    oddsSum += Convert.ToInt32(number[i]);
                }
                else
                {
                    evensSum += Convert.ToInt32(number[i]);
                }
            }
            
            return evensSum > oddsSum;
        }

        static void Swap (ref int A, ref int B)
        {
            int temp = A;
            A = B;
            B = temp;
        }
    }
}
