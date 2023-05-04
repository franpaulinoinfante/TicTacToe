namespace TicTacToe.Models.Types;

internal class ClosedInterval
{
    private readonly int _min;
    private readonly int _max;

    public ClosedInterval(int min, int max)
    {
        _min = min;
        _max = max;
    }

    internal bool IsValid(int value)
    {
        return _min <= value && value <= _max;
    }
}