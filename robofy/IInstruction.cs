namespace robofy
{
    public interface IInstruction
    {
        string Direction { get; }
        int Steps { get; }
    }
}