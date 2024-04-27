// See https://aka.ms/new-console-template for more information
using Evaluator.Logic;

Console.WriteLine("Evaluador de Funciones");
Console.WriteLine("----------------------");

//var expresion = "41*15/(4+61)";
//Console.WriteLine($"{expresion} =  {MyEvaluator.Evaluate(expresion)}");
//Console.WriteLine();

var expresion2 = "41*15,2/(4,4+61)";
Console.WriteLine($"{expresion2} =  {MyEvaluator.Evaluate(expresion2)}");
Console.WriteLine();

//var expresion3 = "41*15.2/(4.4+61)";
//Console.WriteLine($"{expresion3} =  {MyEvaluator.Evaluate(expresion3)}");
Console.WriteLine();

//var expresion4 = "4*(5+6-(8/2^3)-7)-1";
//Console.WriteLine($"{expresion4} =  {MyEvaluator.Evaluate(expresion4)}");
Console.WriteLine();