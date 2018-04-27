using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    public class ExampleTests2
    {
        [Test,]
        public void can_retract_two_numbers()
        {
            //arrange
            var firstNumber = 2;
            var secondNumber = 4;

            //act
            var result = firstNumber - secondNumber;

            //assert
            Assert.AreEqual(-2, result);
        }


    }
}
