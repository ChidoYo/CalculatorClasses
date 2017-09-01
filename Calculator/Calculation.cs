using System;

namespace Calculator
{
    public class Calculation
    {
        public static void Execution(float first, string operation, float second)
        {
            float result;

			switch (operation)
			{
				case "+":
					result = first + second;
					Console.WriteLine("{0} + {1} = {2}", first, second, result);
					break;
				case "-":
					result = first - second;
					Console.WriteLine("{0} - {1} = {2}", first, second, result);
					break;
				case "*":
					result = first * second;
					Console.WriteLine("{0} x {1} = {2}", first, second, result);
					break;
				case "/":
					result = first / second;
					Console.WriteLine("{0} / {1} = {2}", first, second, result);
					break;
				default:
					break;
			}
        }
    }
}
