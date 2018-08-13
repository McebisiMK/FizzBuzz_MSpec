using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMSpec.FizzBuzzKata.Tests
{
    [Subject("Given number is five should return BuzzWhiz")]
    class When_Number_Is_Five_Should_Return_BuzzWhiz
    {
        //--------------Arrange-----------------
        static int number = 5;
        static FizzBuzz fizzBuzz;

        Establish context = () =>
                fizzBuzz = new FizzBuzz();

        //--------------Act--------------------
        static string actual;
        Because of = () =>   
                actual = fizzBuzz.FizzBuzzer(number);

        //--------------Act--------------------
        static string expected = "BuzzWhiz";
        It Should_Return_Number = () =>
                actual.ShouldEqual(expected);
    }
}
