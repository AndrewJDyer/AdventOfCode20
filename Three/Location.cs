namespace Three;

class Location
{
    public int Row { get; }
    public int Column { get; }

    public static Location Starting => new(0, 0);

    private Location(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public Location GetNext(Slope slope) => new(Row + slope.Right, Column + slope.Down);
}