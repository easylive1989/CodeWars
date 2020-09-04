using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    // https://www.codewars.com/kata/52f78966747862fc9a0009ae
    // 6 kyu
    public class ReverseCalculator
    {
        public double Evaluate(string expressions)
        {
            var operatorDict = new Dictionary<string, Func<double, double, double>>()
            {
                {"+", (operator1, operator2) => operator1 + operator2 },
                {"-", (operator1, operator2) => operator1 - operator2 },
                {"*", (operator1, operator2) => operator1 * operator2 },
                {"/", (operator1, operator2) => operator1 / operator2 },
            };

            var operands = new List<double>();
            foreach (var expression in expressions.Split(' '))
            {
                if (operatorDict.ContainsKey(expression))
                {
                    var tmp = operatorDict[expression](operands[operands.Count - 2], operands[operands.Count - 1]);
                    operands.RemoveAt(operands.Count - 2);
                    operands.RemoveAt(operands.Count - 1);
                    operands.Add(tmp);
                }
                else
                {
                    operands.Add(Double.Parse(expression));
                }
            }
    
            return operands.First();
        }
    }
}