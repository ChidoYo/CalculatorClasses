using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalculator
{
	class OperationType
	{
		public string Operator { get; set; }
		public static OperationType GetOperator(string opType)
		{
			var newOperator = new OperationType() { Operator = opType };
			return newOperator;
		}
	}
}
