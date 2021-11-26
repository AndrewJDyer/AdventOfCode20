// See https://aka.ms/new-console-template for more information
using Three;

var parser = new InputParser(@"C:\Users\hapdy\OneDrive\Andy\Code\AdventOfCode20\Three\input.txt");
var map = parser.Parse();
var evaluator = new JourneySetEvaluator(map);
var trees = evaluator.EvaluateSlope(new(1, 1)) *
            evaluator.EvaluateSlope(new(1, 3)) *
            evaluator.EvaluateSlope(new(1, 5)) *
            evaluator.EvaluateSlope(new(1, 7)) *
            evaluator.EvaluateSlope(new(2, 1));

//1744787392
Console.WriteLine(trees);
