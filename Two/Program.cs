// See https://aka.ms/new-console-template for more information

using Two;

var rowContents = File.ReadAllLines(@"C:\Users\hapdy\OneDrive\Andy\Code\AdventOfCode20\Two\input.txt");
var nonEmptyRows = rowContents.Where(r => r != "");

var rows = nonEmptyRows.Select(r => new RowParser(r).Parse());
var validRows = rows.Where(r => r.IsConsistentWithPolicy());
Console.WriteLine(validRows.Count());
