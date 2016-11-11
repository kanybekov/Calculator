using System.Collections.Generic;

namespace CalculatorLibrary.Calculation
{
    public class Parser : IParser
    {
        public IEnumerable<string> GeneratePostfixExpression(string input)
        {
            //return input;


            var tokens = input.Split(' ');

            var s = new Stack<string>();
            var outputList = new List<string>();
            int n;
            foreach (var c in tokens)
            {
                if (int.TryParse(c, out n))
                {
                    outputList.Add(c);
                }
                if (c == "(")
                {
                    s.Push(c);
                }
                if (c == ")")
                {
                    while (s.Count != 0 && s.Peek() != "(")
                    {
                        outputList.Add(s.Pop());
                    }
                    s.Pop();
                }
                if (IsOperator(c))
                {
                    while (s.Count != 0 && Priority(s.Peek()) >= Priority(c))
                    {
                        outputList.Add(s.Pop());
                    }
                    s.Push(c);
                }
            }
            while (s.Count != 0)
            {
                outputList.Add(s.Pop());
            }
            return outputList;
        }

        static int Priority(string c)
        {
            if (c == "^")
            {
                return 3;
            }
            else if (c == "*" || c == "/")
            {
                return 2;
            }
            else if (c == "+" || c == "-")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static bool IsOperator(string c)
        {
            if (c == "+" || c == "-" || c == "*" || c == "/" || c == "^")
            {
                return true;
            }
            return false;
        }
    }
}