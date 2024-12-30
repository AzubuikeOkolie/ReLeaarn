public class Program
{
    private static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        var calResult = Calculator.AddNumber(7, 7);
        Console.WriteLine($"Result of 7 + 7 = {calResult}");

        ProgrammerCalculator programmerCalculator = new();
        var programmerCalcResult = ProgrammerCalculator.Power(4, 5);
        Console.WriteLine($"Power of 4, 5 from {programmerCalculator} and answer is {programmerCalcResult}");

        ScientificCalculator scientificCalculator = new();
        var scientificCalcResult = ScientificCalculator.Or(90, 5);
        Console.WriteLine($"Annswer is {scientificCalcResult}");
    }

    public class Calculator()
    {
        public static double AddNumber(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    public class ProgrammerCalculator : Calculator
    {
        public static double Power(double num, double pow)
        {
            return Math.Pow(num, pow);
        }
    }

    public class ScientificCalculator : Calculator
    {
        public static int Or(int num1, int num2)
        {
            return num1 | num2;
        }
    }
}