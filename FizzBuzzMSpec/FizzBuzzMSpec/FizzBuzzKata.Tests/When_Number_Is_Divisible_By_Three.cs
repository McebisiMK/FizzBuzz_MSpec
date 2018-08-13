using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMSpec.FizzBuzzKata.Tests
{
    [Subject("Given number divisible by three should return fizz")]
    public class When_Number_Is_Divisible_By_Three
    {
        //-----------------Arrange---------------
        static int number = 9;
        static FizzBuzz fizzBuzz;

        Establish context = () =>
            fizzBuzz = new FizzBuzz();

        //----------------Act------------------
        static string actual;   
        Because of = () =>
        actual = fizzBuzz.FizzBuzzer(number);

        //---------------Assert----------------
        static string expected = "Fizz";
        It Should_Return_Fizz = () =>
        actual.ShouldEqual(expected);
    }
}
