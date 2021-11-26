namespace Three;

class Journey
{
    private readonly Map map;
    private readonly Slope slope;

    public Journey(Map map, Slope slope)
    {
        this.map = map;
        this.slope = slope;
    }

    public int CountTrees()
    {
        int trees = 0;
        for (var location = Location.Starting; location.Column < map.Length; location = location.GetNext(slope))
        {
            if (map.HasTreeAt(location))
                trees++;
        }

        return trees;
    }
}