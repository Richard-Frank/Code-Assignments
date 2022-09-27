using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLayer
{
    public class CCalculator
    {


        public void CalcPlus(decimal Number1, decimal Number2, out decimal Result)
        {
            Result = Number1 + Number2;
        }

        public void CalcMinus(decimal Number1, decimal Number2, out decimal Result)
        {
            Result = Number1 - Number2;
        }

        public void CalcMultiply(decimal Number1, decimal Number2, out decimal Result)
        {
            Result = Number1 * Number2;
        }

        public void CalcDivide(decimal Number1, decimal Number2, out decimal Result)
        {
            Result = Number1 / Number2;
        }


        public void CalcReciprocal(decimal Number1, decimal Number2, out decimal Result)
        {
            Number1 = 1;
            Result = Number1 / Number2;
        }

    }
}
