using TicTacToe.Models.Types;

namespace TicTacToe.Models;

internal abstract class Player
{
    private readonly Grid _grid;
    private readonly Token _token;
    private readonly PlayerType _playerType;

    public Player(Grid grid, Token token, PlayerType playerType)
    {
        _grid = grid;
        _token = token;
        _playerType = playerType;
    }

    internal void SetToken(Token token)
    {
        throw new NotImplementedException();
    }
}