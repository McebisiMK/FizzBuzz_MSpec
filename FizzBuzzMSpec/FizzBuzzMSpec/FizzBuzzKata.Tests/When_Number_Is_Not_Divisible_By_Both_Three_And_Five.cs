using Machine.Specifications;
using System;
using System.Collections.Generic;
using FizzBuzzMSpec;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMSpec.FizzBuzzKata.Tests
{
    [Subject("Given number not divisible by both three and five should return that number")]
    class When_Number_Is_Not_Divisible_By_Both_Three_And_Five
    {
        //--------------Arrange-----------------
        static int number = 1;
        static FizzBuzz fizzBuzz;

        Establish context = () =>
                fizzBuzz = new FizzBuzz();

        //--------------Act--------------------
        static string actual;
        Because of = () => 
                actual = fizzBuzz.FizzBuzzer(number);
            
        //--------------Act--------------------
        static string expected = number.ToString();
        It Should_Return_Number = () =>
                actual.ShouldEqual(expected);
    }
}
