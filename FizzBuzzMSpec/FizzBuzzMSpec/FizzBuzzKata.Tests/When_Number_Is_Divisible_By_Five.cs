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
        static int number = 20;
        static FizzBuzz fizzBuzz;

        Establish b = () =>
                fizzBuzz = new FizzBuzz();

        //---------------Act-------------------
        static string actual;
        Because c = () =>
                actual = fizzBuzz.FizzBuzzer(number);

        //---------------Assert----------------
        static string expected = "Buzz";
        It Should_Return_Buzz = () =>
                actual.ShouldEqual(expected);
    }
}
