namespace CalculatorTest.CoreLib
{
    public interface ISimpleCalculator
    {
        int Add(int start, int amount);
        int Subtract(int start, int amount);
        int Divide(int start, int by);
        int Multiply(int start, int by);        
    }
}