using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMSpec.FizzBuzzKata.Tests
{
    [Subject("Given number is a prime should return whiz")]
    class When_Number_Is_Prime_Return_Whiz
    {
        //--------------Arrange------------------
        static int number = 2;
        static FizzBuzz fizzBuzz;

        Establish context = () =>
                fizzBuzz = new FizzBuzz();

        //--------------Act---------------------
        static string actual;
        Because of = () =>
                actual = fizzBuzz.FizzBuzzer(number);

        //--------------Arrange------------------
        static string expected = "Whiz";
        It Should_Return_Whiz = () =>
                actual.ShouldEqual(expected);
    }
}
