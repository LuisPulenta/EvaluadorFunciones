namespace Evaluator.Logic
{
    public class MyEvaluator
    {
        public static double Evaluate(string infix)
        {
            var prefix = ToPostfix(infix);
            return Calculate(prefix);
        }

        private static double Calculate(object postfix)
        {
            throw new NotImplementedException();
        }

        private static object ToPostfix(string infix)
        {
            throw new NotImplementedException();
        }

        private int PriorityInExpression(char @operator)
        {
            switch (@operator){
                case '^': return 4;
                case '*': return 2;
                case '/': return 2;
                case '+': return 1;
                case '-': return 1;
                case '(': return 5;
                default: throw new Exception("Not valid operator");
            }
        }

        private int PriorityInStack(char @operator)
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