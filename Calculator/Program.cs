using System;
using Calculator;

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

				//Operator Selected
				OperationType newOperation = OperationType.GetOperator(operationType);

				Console.WriteLine("Enter your second number");
				float secondNumber = float.Parse(Console.ReadLine());

                // Operation done
                Calculation.Execution(firstNumber, newOperation.Operator, secondNumber);


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