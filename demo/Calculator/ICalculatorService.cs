namespace Calculator
{
    public interface ICalculatorService
    {
        double Add(double firstOperand, double secondOperand);
        double Subtract(double firstOperand, double secondOperand);
        double Multiply(double firstOperand, double secondOperand);
        double Divide(double firstOperand, double secondOperand);
    }
}