namespace TicTacToe.Models;

internal class Turn
{
    public const int MaxPlayer = 2;

    private readonly Player[] _players;

    private int _current;

    public Turn(Player[] players)
    {
        _players = players;
        _current = new Random().Next(minValue: 0, maxValue: Turn.MaxPlayer);
    }

    public int Current { get { return _current; } }

    internal void Next()
    {
        _current = (_current + 1) % Turn.MaxPlayer;
    }
}