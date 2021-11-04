using System.Collections.Generic;
using System.Linq;

namespace task3
{
    public class Calculator
    {
        private Stack<int> _stack = new();

        private List<string> ParseWords(string text)
            => text.Split(' ')
                .ToList();

        public int Calculate(string expression)
        {
            var expressionList = ParseWords(expression);

            foreach (var item in expressionList)
            {
                if (int.TryParse(item, out int value))
                {
                    _stack.Push(value);
                    continue;
                }
                СalculateTheExpression(item);
            }

            return _stack.Pop();
        }

        private void СalculateTheExpression(string operation)
        {
            var value1 = _stack.Pop();
            var value2 = _stack.Pop();

            switch (operation)
            {
                case "+": 
                    _stack.Push(value2 + value1);
                    break;

                case "-": 
                    _stack.Push(value2 - value1);
                    break;

                case "*": 
                    _stack.Push(value2 * value1);
                    break;

                case "/":
                    _stack.Push(value2 / value1);
                    break;
            }
        }
    }
}
