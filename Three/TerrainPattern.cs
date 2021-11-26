namespace Three;
class TerrainPattern
{
    private readonly IReadOnlyList<Terrain> terrain;

    public int Length => terrain.Count;

    public TerrainPattern(IEnumerable<Terrain> terrain) => this.terrain = terrain.ToList();

    public Terrain this[int index] => terrain[index];
}
