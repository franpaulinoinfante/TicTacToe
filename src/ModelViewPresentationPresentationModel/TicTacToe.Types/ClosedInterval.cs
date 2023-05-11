namespace TicTacToe.Types;

internal class ClosedInterval
{
    public ClosedInterval(int min, int max)
    {
        Min = min;
        Max = max;
    }

    internal int Min { get; set; }

    internal int Max { get; set; }

    internal bool IsInclude(int value)
    {
        return (Min <= value) && (value <= Max);
    }
}
