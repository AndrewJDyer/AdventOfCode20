using One;

Console.WriteLine("Hello, World!");

var filePath = @"C:\Users\hapdy\OneDrive\Andy\Code\AdventOfCode20\One\input.txt";
var expenseValues = new Parser(filePath).Parse();

var calc = new Calculator(expenseValues);
var multiplication = calc.GetMultiplication();

Console.WriteLine(multiplication);
