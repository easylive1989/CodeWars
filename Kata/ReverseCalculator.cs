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
                {"+", (operator2, operator1) => operator1 + operator2 },
                {"-", (operator2, operator1) => operator1 - operator2 },
                {"*", (operator2, operator1) => operator1 * operator2 },
                {"/", (operator2, operator1) => operator1 / operator2 },
            };

            var operands = new Stack<double>();
            foreach (var expression in expressions.Split(' '))
            {
                if (operatorDict.ContainsKey(expression))
                {
                    operands.Push(operatorDict[expression](operands.Pop(), operands.Pop()));
                }
                else
                {
                    operands.Push(double.Parse(expression));
                }
            }
    
            return operands.First();
        }
    }
}