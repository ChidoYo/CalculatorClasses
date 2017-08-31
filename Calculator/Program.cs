using System;
using System.Text.RegularExpressions;

namespace MyCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Erick's Calculator.\n\n");

			while (true)
			{
				Console.WriteLine("Enter your first number");
				float firstNumber = float.Parse(Console.ReadLine());

				Console.WriteLine("Enter operator ( +, -, *, or /)");
				string operationType = Console.ReadLine();

				while (true)
				{
					var regex = @"[*+/-]";
					var match = Regex.Match(operationType, regex);

					if (!match.Success)
					{
						Console.WriteLine("Enter correct operator ( +, -, *, or /)");
						operationType = Console.ReadLine();
					}
					else
					{
						break;
					}
				}

				//Test
                OperationType newOperation = OperationType.GetOperator(operationType);
				Console.WriteLine("You selected: {0}", newOperation.Operator);

				Console.WriteLine("Enter your second number");
				float secondNumber = float.Parse(Console.ReadLine());

				float result;

				switch (operationType)
				{
					case "+":
						result = firstNumber + secondNumber;
						Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);
						break;
					case "-":
						result = firstNumber - secondNumber;
						Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);
						break;
					case "*":
						result = firstNumber * secondNumber;
						Console.WriteLine("{0} x {1} = {2}", firstNumber, secondNumber, result);
						break;
					case "/":
						result = firstNumber / secondNumber;
						Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);
						break;
					default:
						break;
				}

				Console.WriteLine("One more try?");
				string response = Console.ReadLine();

				if (response.ToLower() == "no" || response.ToLower() == "quit")
				{
					break;
				}
				else
				{
					continue;
				}
			}
		}
	}
}