using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMSpec
{
    public class FizzBuzz
    {
        public string FizzBuzzer(int number)
        {
            var fizz = DivisibleByThree(number);
            var buzz = DivisibleByFive(number);
            var prime = GetPrime(number);
            if (NotDivisibleByThreeAndFive(fizz, buzz))
            {
                if (string.IsNullOrEmpty(prime))
                {
                    return number.ToString();
                }
                return prime;
            }
            return $"{fizz}{buzz}";
        }

        private bool Divisible(int number, int factor)
        {
            return number % factor == 0;
        }

        private string DivisibleByFive(int number)
        {
            var buzz = "";
            if (number % 5 == 0)
            {
                var prime = GetPrime(number);
                buzz = $"Buzz{prime}";
            }
            return buzz;
        }

        private string DivisibleByThree(int number)
        {
            var fizz = "";
            if (number % 3 == 0)
            {
                var prime = GetPrime(number);
                fizz = $"Fizz{prime}";
            }
            return fizz;
        }


        private string GetPrime(int number)
        {
            var isPrime = Enumerable.Range(1, number)
                .Where(factor => Divisible(number, factor))
                .Count()==2;

            if (isPrime)
            {
                return "Whiz";
            }
            return "";
        }

        private static bool NotDivisibleByThreeAndFive(string fizz, string buzz)
        {
            return string.IsNullOrEmpty(fizz) && string.IsNullOrEmpty(buzz);
        }
    }
}
