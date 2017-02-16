using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FizzBuzzPlus
{
    public class Program
    {
        public static string FizzBuzzPlus(int n)
        {
            if (MultipleOf3AndContains5(n)
                || MultipleOf5AndContains3(n)
                || HasThree(n) && HasFive(n))
                return "FizzBuzz";

            if (n % 3 == 0 || HasThree(n))
                return "...Fizz...";

            if (n % 5 == 0 || HasFive(n))
            {
                return "...Buzz...";
            }

            return n.ToString();
        }

        private static bool MultipleOf3AndContains5(int n)
        {
            return (n % 3 == 0 && HasFive(n));
        }

        private static bool MultipleOf5AndContains3(int n)
        {
            return (n % 5 == 0 && HasThree(n));
        }

        private static bool HasFive(int n)
        {
            return n.ToString().Contains("5");
        }

        private static bool HasThree(int n)
        {
            return n.ToString().Contains("3");
        }

        static void Main(string[] args)
        {
            for (int i= 1; i<=100; i++)
            {
                Console.WriteLine(FizzBuzzPlus(i));
            }
            Console.Read();
        }
    }
}
