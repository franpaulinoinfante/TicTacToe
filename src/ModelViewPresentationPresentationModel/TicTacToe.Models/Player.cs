using TicTacToe.Types;

namespace TicTacToe.Models;

internal class Player
{
    private readonly Token _token;
    private readonly Board _board;
    private readonly PlayerType _userPlayer;

    public Player(Token token, Board board, PlayerType userPlayer)
    {
        _token = token;
        _board = board;
        _userPlayer = userPlayer;
    }
}