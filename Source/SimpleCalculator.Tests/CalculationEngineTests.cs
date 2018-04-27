using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    public class CalculationEngineTests
    {
        [TestCase("5", 5)]
        [TestCase("3", 3)]
        [TestCase("123", 123)]
        public void evaluation_of_number_should_return_the_number_itself(
            string operation,
            int expectedResult)
        {
            //act
            var result = CalculationEngine.Evaluate(operation);
            
            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("1+2", 3)]
        [TestCase("2+5", 7)]
        [TestCase("111+222", 333)]
        [TestCase("3-2", 1)]
        [TestCase("2-5", -3)]
        [TestCase("111-222", -111)]
        public void can_add_two_numbers(
            string operation,
            int expectedResult)
        {
            //act
            var result = CalculationEngine.Evaluate(operation);

            //assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
