using TicTacToe.Types;

namespace TicTacToe.Models;

internal class Player
{
    private const int MaxToken = 3;

    private readonly Token _token;
    private readonly Board _board;
    private readonly PlayerType _playerType;

    private int _tokens;

    public Player(Token token, Board board, PlayerType playerType)
    {
        _token = token;
        _board = board;
        _playerType = playerType;

        Reset();
    }

    public Token Token => _token;

    public PlayerType PlayerType => _playerType;

    internal void Reset()
    {
        _tokens = Player.MaxToken;
    }

    internal bool HasToken()
    {
        return _tokens > 0;
    }

    internal void PutToken(Coordinate coordinate)
    {
        _board.PutToken(coordinate, _token);
        _tokens--;
    }

    internal Error FindToPutTokenError(Coordinate coordinate)
    {
        if (!_board.IsEmpty(coordinate))
        {
            return Error.SquareIsOccupied;
        }

        return Error.Null;
    }

    internal void MoveToken(Coordinate[] coordinates)
    {
        _board.MoveToken(coordinates);
    }

    internal Error FindOriginToMoveError(Coordinate coordinate)
    {
        if (_board.IsEmpty(coordinate))
        {
            return Error.SquareIsEmpty;
        }

        if (!_board.IsOccupied(coordinate, _token))
        {
            return Error.NotOwnerToken;
        }

        return Error.Null;
    }

    internal Error FindTargetToMoveError(Coordinate[] coordinates)
    {
        const int origin = 0;
        const int target = 1;

        if (!_board.IsEmpty(coordinates[target]))
        {
            return Error.SquareIsOccupied;
        }
        if (coordinates[origin].Equals(coordinates[target]))
        {
            return Error.OriginAndTargetCoordinateCannotBeSame;
        }

        return Error.Null;
    }
}