﻿// See https://aka.ms/new-console-template for more information
using Evaluator.Logic;

Console.WriteLine("Evaluador de Funciones");
Console.WriteLine("----------------------");
var expresion = "4*5/(4+6)";
var expresion2 = "4*(5+6-(8/2^3)-7)-1";
Console.WriteLine($"{ expresion} =  {MyEvaluator.Evaluate(expresion)}");
Console.WriteLine($"{expresion2} =  {MyEvaluator.Evaluate(expresion2)}");