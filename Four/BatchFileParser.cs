namespace Four;
public class BatchFileParser
{
    private readonly string inputFilePath;

    public BatchFileParser(string inputFilePath)
    {
        this.inputFilePath = inputFilePath;
    }

    private IEnumerable<IEnumerable<string>> GroupLinesByPassport()
    {
        IEnumerable<string> allLines = File.ReadAllLines(inputFilePath);
        var linesEnumerator = allLines.GetEnumerator();
        var currentGroup = new List<string>();
        while (linesEnumerator.MoveNext())
        {
            if (String.IsNullOrWhiteSpace(linesEnumerator.Current))
            {
                yield return currentGroup;
                currentGroup = new();
            }
            else
            {
                currentGroup.Add(linesEnumerator.Current);
            }
        }
    }

    private static IEnumerable<string> GetNextPassportLines(IEnumerator<string> linesEnumerator)
    {
        while (linesEnumerator.MoveNext())
        {
            if (String.IsNullOrWhiteSpace(linesEnumerator.Current))
                yield break;
            else
                yield return linesEnumerator.Current;
        }
    }
}
