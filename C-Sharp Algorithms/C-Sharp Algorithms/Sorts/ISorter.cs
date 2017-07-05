namespace C_Sharp.Sorts
{
    public interface ISorter
    {
        string Name { get; }
        int[] Sort(int[] arr);
    }
}
