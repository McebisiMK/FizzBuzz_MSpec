using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMSpec.FizzBuzzKata.Tests
{
    [Subject("Given number is three should return FizzWhiz")]
    class When_Number_Is_Three_Should_Return_FizzBuzz
    {
        //--------------Arrange-----------------
        static int number = 3;
        static FizzBuzz fizzBuzz;

        Establish context = () =>
                fizzBuzz = new FizzBuzz();

        //--------------Act--------------------
        static string actual;
        Because of = () =>
                actual = fizzBuzz.FizzBuzzer(number);

        //--------------Act--------------------
        static string expected = "FizzWhiz";
        It Should_Return_Number = () => 
                actual.ShouldEqual(expected);
    }
}
