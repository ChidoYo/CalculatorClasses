using System;
using System.Text.RegularExpressions;

namespace MyCalculator
{
	class OperationType
	{
		public string Operator { get; set; }

		public static OperationType GetOperator(string opType)
		{
			
            //Console.WriteLine("This is OperationType Class!");

			while (true)
			{
				var regex = @"[*+/-]";
				var match = Regex.Match(opType, regex);

				if (!match.Success)
				{
					Console.WriteLine("Enter correct operator ( +, -, *, or /)");
					opType = Console.ReadLine();
				}
				else
				{
					break;
				}
			}

			var newOperator = new OperationType() { Operator = opType };

			return newOperator;
		}
	}
}
