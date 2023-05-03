namespace TicTacToe.Models;

internal class Turn
{
    public const int MaxPlayer = 2;

    private readonly Player[] _players;

    private readonly int _current;

    public Turn(Player[] players)
    {
        _players = players;
    }
}