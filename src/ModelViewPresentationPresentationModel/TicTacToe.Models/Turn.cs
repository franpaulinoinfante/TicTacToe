using TicTacToe.Types;

namespace TicTacToe.Models;

internal class Turn
{
    public const int NumberOfPlayers = 2;

    private readonly Player[] _players;

    public Turn(Player[] players)
    {
        _players = players;
    }

    internal void SetGameModePlayers(int gameModePlayers, Board board)
    {
        for (int i = 0; i < gameModePlayers; i++)
        {
            _players[i] = new Player(Enum.GetValues<Token>()[i], board, PlayerType.UserPlayer);
        }

        for (int i = gameModePlayers; i < Turn.NumberOfPlayers; i++)
        {
            _players[i] = new Player(Enum.GetValues<Token>()[i], board, PlayerType.MachinePlayer);
        }
    }
}