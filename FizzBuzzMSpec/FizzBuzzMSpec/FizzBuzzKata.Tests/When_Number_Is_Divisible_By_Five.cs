using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMSpec.FizzBuzzKata.Tests
{
    [Subject("Given number divisible by five should return buzz")]
    class When_Number_Is_Divisible_By_Five
    {
        //---------------Arrange---------------
        static int number = 10;
        static FizzBuzz fizzBuzz;

        Establish context = () =>
                fizzBuzz = new FizzBuzz();

        //---------------Act-------------------
        static string actual;
        Because of = () =>
                actual = fizzBuzz.FizzBuzzer(number);

        //---------------Assert----------------
        static string expected = "Buzz";
        It Should_Return_Buzz = () =>
                actual.ShouldEqual(expected);
    }
}
