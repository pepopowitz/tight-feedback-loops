using System;

namespace Calculator
{
    public class CalculatorService : ICalculatorService
    {
        public double Add(
            double firstOperand, 
            double secondOperand)
        {
            return firstOperand + secondOperand;
        }

        public double Divide(
            double firstOperand, 
            double secondOperand)
        {
            if (secondOperand == 0)
            {
                throw new MathException();
            }

            return firstOperand / secondOperand;
        }

        public double Multiply(
            double firstOperand, 
            double secondOperand)
        {
            throw new NotImplementedException();
        }

        public double Subtract(
            double firstOperand, 
            double secondOperand)
        {
            throw new NotImplementedException();
        }
    }
}