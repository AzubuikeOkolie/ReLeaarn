namespace Chapter03
{
    public class Calculator
    {
        static void Main()
        {
            double firstNumber = GetFirstNumber();

            double secondNumber = GetSecondNumber();

            double result = AddNumbers(firstNumber, secondNumber);

            PrintResult(result);
        }

        static double GetFirstNumber()
        {
            Console.WriteLine("Ener first number: ");

            string fistNumberInput = Console.ReadLine();
            double firstNumber = double.Parse(fistNumberInput);

            return firstNumber;
        }

        static double GetSecondNumber()
        {
            Console.WriteLine("Ener second number: ");

            string secondNumberInput = Console.ReadLine();
            double secondNumber = double.Parse(secondNumberInput);

            return secondNumber;
        }

        static double AddNumbers(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }

        static void PrintResult(double result)
        {
            Console.WriteLine($"The result is: {result}");
        }
    }

}
