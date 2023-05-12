using TicTacToe.Types;

namespace TicTacToe.Models;

internal class Turn
{
    internal const int NumberOfPlayers = 2;

    private readonly Player[] _players;

    public Turn(Player[] players)
    {
        _players = players;
        Current = default;
    }

    internal int Current { get; private set; }

    internal void Next()
    {
        Current = (Current + 1) % Turn.NumberOfPlayers;
    }

    internal void SetGameModePlayers(GameMode gameModePlayers, Board board)
    {
        for (int i = 0; i < (int)gameModePlayers; i++)
        {
            _players[i] = new Player(Enum.GetValues<Token>()[i], board, PlayerType.UserPlayer);
        }

        for (int i = (int)gameModePlayers; i < Turn.NumberOfPlayers; i++)
        {
            _players[i] = new Player(Enum.GetValues<Token>()[i], board, PlayerType.MachinePlayer);
        }
    }
}