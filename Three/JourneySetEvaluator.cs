namespace Three;
class JourneySetEvaluator
{
    private readonly Map map;

    public JourneySetEvaluator(Map map) => this.map = map;

    public int EvaluateSlope(Slope slope) => new Journey(map, slope).CountTrees();
}
