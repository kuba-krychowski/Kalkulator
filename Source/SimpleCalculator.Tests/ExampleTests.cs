using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    public class ExampleTests
    {
        [Test]
        public void can_add_two_numbers()
        {
            //arrange
            var firstNumber = 2;
            var secondNumber = 3;

            //act
            var result = firstNumber + secondNumber;

            //assert
            Assert.AreEqual(5, result);
        }
    }
}
