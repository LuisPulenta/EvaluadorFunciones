// See https://aka.ms/new-console-template for more information
using Evaluator.Logic;

Console.WriteLine("Evaluador de Funciones");
Console.WriteLine("----------------------");

//var expresion = "10+20";
//Console.WriteLine($"{expresion} =  {MyEvaluator.Evaluate(expresion)}");

var expresion = "41*15.2/(4.4+61)";
Console.WriteLine($"{expresion} =  {MyEvaluator.Evaluate(expresion)}");

//var expresion2 = "4*(5+6-(8/2^3)-7)-1";
//Console.WriteLine($"{expresion2} =  {MyEvaluator.Evaluate(expresion2)}");