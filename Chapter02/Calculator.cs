﻿namespace Chapter02
{
    public class Calculator
    {
        public static void Calculate()
        {
            char firstChar = 'Q';
            bool keepRunning = true;

            do
            {
                Console.WriteLine();
                Console.Write("What do you want to do? (Add, Subtract, Multiply, Divide, Quit): ");

                string input = Console.ReadLine();
                firstChar = input[0];

                keepRunning = !(firstChar == 'q' || firstChar == 'Q');

                double firstNumber = 0;
                double secondNumber = 0;

                if (keepRunning)
                {
                    Console.Write("First Number: ");
                    string firstNumberInput = Console.ReadLine();
                    firstNumber = double.Parse(firstNumberInput);

                    Console.Write("Second Number: ");
                    string secondNumberInput = Console.ReadLine();
                    secondNumber = double.Parse(secondNumberInput);
                }

                double result = 0;
                switch (firstChar)
                {
                    case 'a':
                    case 'A':
                        result = firstNumber + secondNumber;
                        break;
                    case 's':
                    case 'S':
                        result = firstNumber - +secondNumber;
                        break;
                    case 'm':
                    case 'M':
                        result = firstNumber * secondNumber;
                        break;
                    case 'd':
                    case 'D':
                        result = firstNumber / secondNumber;
                        break;
                    default:
                        result = -1;
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Your result is " + result);

            } while (keepRunning);
        }
    }
}
