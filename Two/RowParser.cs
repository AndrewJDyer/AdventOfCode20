using System.Text.RegularExpressions;

namespace Two;
class RowParser
{
    private readonly string rowText;

    public RowParser(string rowText) => this.rowText = rowText;

    public Row Parse()
    {
        var match = Regex.Match(this.rowText, @"(\d+)-(\d+) ([a-z]): ([A-Za-z]+)");
        var lower =Int32.Parse(match.Groups[1].Value);
        var upper = Int32.Parse(match.Groups[2].Value);
        var character = match.Groups[3].Value[0];
        var password = match.Groups[4].Value;

        var range = new Range(lower, upper);
        var policy = new Policy(range, character);
        var row = new Row(policy, new(password));

        return row;
    }
}