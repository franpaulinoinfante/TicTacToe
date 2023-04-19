using System.Diagnostics;
using TicTacToe.ConsoleApp.Models.Players;

namespace TicTacToe.ConsoleApp.Models;

internal class Turn
{
    internal const int PlayersNumber = 2;

    private Player[] _players;
    private int _current;

    public Turn()
    {
        _players = new Player[Turn.PlayersNumber];
        _current = 0;
    }

    internal Player[] Player
    {
        set
        {
            Debug.Assert(value != null);

            _players = value;
        }
    }

    internal Player Current
    {
        get
        {
            return _players[_current];
        }
    }

    internal void Next()
    {
        _current = (_current + 1) % PlayersNumber;
    }

    internal void WriteLine()
    {
        Message.CurrentTurn.WriteLine(_players[_current].Token.ToString());
    }
}