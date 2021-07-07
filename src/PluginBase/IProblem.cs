namespace PluginBase
{
    public interface IProblem
    {
        int Number { get; }
        string Name { get; }
        string Description { get; }

        string GetSolution();
    }
}
