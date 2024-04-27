namespace Evaluator.Logic
{
    public class MyEvaluator
    {
        public static double Evaluate(string infix)
        {
            var postfix = ToPostfix(infix);
            Console.WriteLine($"Infix: {infix}");
            Console.WriteLine($"Postfix: {postfix}");
            //return 0;
            return Calculate(postfix);
        }

        private static double Calculate(string postfix)
        {
            var stack = new Stack<double>();
            for (int i = 0; i < postfix.Length; i++)
            {
                if (IsOperator(postfix[i]))
                {
                    var number2 = stack.Pop();
                    var number1 = stack.Pop();
                    var result = Calculate(number1, postfix[i], number2);
                    stack.Push(result);
                }
                else
                {
                    i++;
                    var numberString = string.Empty;
                    while (postfix[i] != ']')
                    {
                        numberString += postfix[i];
                        i++;
                    }
                    var number = Convert.ToDouble(numberString);
                    stack.Push(number);
                }
            }
            return stack.Pop();
        }

        private static double Calculate(double number1, char @operator, double number2)
        {
            switch (@operator)
            {
                case '^': return Math.Pow(number1, number2);
                case '*': return number1 * number2;
                case '/': return number1 / number2;
                case '+': return number1 + number2;
                case '-': return number1 - number2;
                default: throw new Exception("Not valid operator");
            }
        }

        private static string ToPostfix(string infix)
        {
            var isFirstNumber = true;
            var isClosedNumber = false;

            var stack = new Stack<char>(100);
            var postfix = string.Empty;
            for (int i = 0; i < infix.Length; i++)
            {
                if (IsOperator(infix[i]))
                {
                    if (!isClosedNumber)
                    {
                        if (!string.IsNullOrEmpty(postfix))
                        {
                            postfix += ']';
                            isClosedNumber = true;
                        }                        
                    }
                    
                    isFirstNumber = true;

                    if (stack.Count==0)
                    {
                        stack.Push(infix[i]);
                    }
                    else
                    {
                        if (infix[i] == ')')
                        {
                            do
                            {
                                postfix += stack.Pop();
                            } while (stack.Peek() != '(');
                            stack.Pop();
                        }
                        else
                        {
                            if (PriorityInExpression(infix[i]) > PriorityInStack(stack.Peek()))
                            {
                                stack.Push(infix[i]);
                            }
                            else
                            {
                                postfix += stack.Pop();
                                stack.Push(infix[i]);
                            }
                        }
                    }
                }
                else
                {
                    if (isFirstNumber)
                    {
                        postfix += '[';
                        isFirstNumber = false;
                        isClosedNumber = false;
                    }
                    postfix += infix[i];
                }
            }

            var last = postfix[postfix.Length-1];
            if (!IsOperator(last))
            {
                postfix += ']';
            }
            
            while (stack.Count>0)
            {
                postfix += stack.Pop();
            }
            return postfix;
        }

        private static bool IsOperator(char item)
        {
            if (item == '(' || item == ')' || item == '^' || item == '/' || item == '*' || item == '+' || item == '-')
            {
                return true;
            }
            return false;
        }

        private static int PriorityInExpression(char @operator)
        {
            switch (@operator)
            {
                case '^': return 4;
                case '*': return 2;
                case '/': return 2;
                case '+': return 1;
                case '-': return 1;
                case '(': return 5;
                default: throw new Exception("Not valid operator");
            }
        }

        private static int PriorityInStack(char @operator)
        {
            switch (@operator)
            {
                case '^': return 3;
                case '*': return 2;
                case '/': return 2;
                case '+': return 1;
                case '-': return 1;
                case '(': return 0;
                default: throw new Exception("Not valid operator");
            }
        }
    }
}