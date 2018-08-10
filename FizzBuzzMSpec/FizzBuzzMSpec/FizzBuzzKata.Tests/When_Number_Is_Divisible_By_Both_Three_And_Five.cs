using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMSpec.FizzBuzzKata.Tests
{
    [Subject("Given number is five should return BuzzWhiz")]
    class When_Number_Is_Divisible_By_Both_Three_And_Five
    {
        //--------------Arrange-----------------
        static int number = 15;
        static FizzBuzz fizzBuzz;

        Establish b = () =>
                fizzBuzz = new FizzBuzz();

        //--------------Act--------------------
        static string actual;
        Because c = () =>
                actual = fizzBuzz.FizzBuzzer(number);

        //--------------Act--------------------
        static string expected = "FizzBuzz";
        It Should_Return_Number = () =>
                actual.ShouldEqual(expected);
    }
}
