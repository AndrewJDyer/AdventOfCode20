namespace Three;
class Map
{
    private readonly IReadOnlyList<Row> rows;

    public int Length => rows.Count;

    public Map(IEnumerable<Row> rows) => this.rows = rows.ToList();

    public Row this[int index] => rows[index];

    public bool HasTreeAt(Location location) => this[location.Column][location.Row] == Terrain.Tree;
}