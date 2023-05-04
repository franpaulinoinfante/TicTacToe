using TicTacToe.Models.Types;

namespace TicTacToe.Models;

internal abstract class Player
{
    private const int Empty = 0;

    private readonly Grid _grid;
    private readonly Token _token;
    private readonly PlayerType _playerType;

    private int _tokens;

    public Player(Grid grid, Token token, PlayerType playerType)
    {
        _grid = grid;
        _token = token;
        _playerType = playerType;
        _tokens = Coordinate.Dimension;
    }

    public Token Token { get { return _token; } }

    public PlayerType PlayerType { get {  return _playerType; } }

    internal Error CheckErrorToPut(Coordinate coordinate)
    {
        if (!_grid.IsEmpty(coordinate))
        {
            return Error.SquareIsOccupied;
        }

        return Error.Null;
    }

    internal Error CheckOriginErrorToMove(Coordinate coordinate)
    {
        if (_grid.IsEmpty(coordinate))
        {
            return Error.SquareIsOccupied;
        }
        if (!_grid.IsOccupied(coordinate, _token))
        {
            return Error.NotOwned;
        }

        return Error.Null;
    }

    internal Error CheckTargetErrorToMove(Coordinate origin, Coordinate target)
    {
        if (!_grid.IsEmpty(target))
        {
            return Error.SquareIsOccupied;
        }
        if (origin.Equals(target))
        {
            return Error.OriginAndTargetCoordinateCantNotBeSame;
        }

        return Error.Null;
    }

    internal bool HasToken()
    {
        return _tokens > Player.Empty;
    }

    internal void MoveToken(Coordinate origin, Coordinate target)
    {
        _grid.MoveToken(origin, target);
    }

    internal void PutToken(Coordinate coordinate)
    {
        _grid.PutToken(coordinate, _token);
        _tokens--;

    }
}