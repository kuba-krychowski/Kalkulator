using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    //todo read about static functions
    public class CalculationEngine
    {
        public static int Evaluate(string mathematicalOperation)
        {
            if (mathematicalOperation.Contains("+"))
            {
                return PerformAddition(mathematicalOperation);
            }
            return int.Parse(mathematicalOperation);
        }

        //todo read about string.Split() function
        private static int PerformAddition(string addition)
        {
            var firstArgument = addition.Substring(0, 1);
            var secondArgument = addition.Substring(2, 1);
            
            var firstInt = int.Parse(firstArgument);
            var secondInt = int.Parse(secondArgument);

            return firstInt + secondInt;
        }
    }
}
