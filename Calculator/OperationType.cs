using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalculator
{
	class OperationType
	{
		public string Operator { get; set; }
		public static OperationType GetOperator()
		{
			var newOperator = new OperationType() { Operator = "Testing 123" };
			return newOperator;
		}
	}
}
