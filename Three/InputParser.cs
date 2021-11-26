namespace Three;
class InputParser
{
    private readonly string inputFilename;

    public InputParser(string inputFilename) => this.inputFilename = inputFilename;

    public Map Parse() => new(GetRows());

    private IEnumerable<string> GetNonEmptyLines() => File.ReadAllLines(inputFilename);

    private IEnumerable<Row> GetRows() => GetNonEmptyLines().Select(ParseRow);

    private Row ParseRow(string line) => new(new(GetTerrains(line)));

    private static IEnumerable<Terrain> GetTerrains(string line) => line.Select(ToTerrain);

    private static Terrain ToTerrain(char c) => c switch
    {
        '#' => Terrain.Tree,
        '.' => Terrain.EmptySpace,
        _ => throw new InvalidOperationException($"Unexpected terrain '{c}'")
    };
}