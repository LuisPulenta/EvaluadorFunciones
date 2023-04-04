// See https://aka.ms/new-console-template for more information
using Evaluator.Logic;

Console.WriteLine("Evaluador de Funciones");
Console.WriteLine("----------------------");
var expresion = "4*5/(4+6)";
Console.WriteLine($"{ expresion} =  {MyEvaluator.Evaluate(expresion)}");