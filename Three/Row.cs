namespace Three;

class Row
{
    private readonly TerrainPattern pattern;

    public Row(TerrainPattern pattern) => this.pattern = pattern;

    public Terrain this[int index] => pattern[NormaliseIndex(index)];

    private int NormaliseIndex(int index) => index % pattern.Length;
}
