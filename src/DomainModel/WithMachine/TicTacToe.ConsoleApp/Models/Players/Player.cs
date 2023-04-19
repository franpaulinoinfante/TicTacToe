using System.Diagnostics;
using TicTacToe.ConsoleApp.Models.Enums;

namespace TicTacToe.ConsoleApp.Models.Players;

internal abstract class Player
{
    private const int MaxTokens = 3;
    private const int Empty = 0;

    private readonly Token _token;
    private readonly Board _board;

    private int _tokens;

    public Player(Token token, Board board)
    {
        Debug.Assert(board != null);

        _token = token;
        _board = board;
        Reset();
    }

    protected internal Token Token
    {
        get
        {
            return _token;
        }
    }

    protected internal void Reset()
    {
        _tokens = Player.MaxTokens;
    }

    protected internal bool HasToken()
    {
        return _tokens > Player.Empty;
    }

    protected internal void PutToken()
    {
        Coordinate target;
        Error error;
        do
        {
            target = GetCoordinate(Message.EnterCoordinateToPut);
            error = CheckErrorToPuToken(target);
        } while (!error.IsNull());

        _board.Put(_token, target);
        _tokens--;
    }

    protected abstract Coordinate GetCoordinate(Message message);

    private protected virtual Error CheckErrorToPuToken(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        return !_board.IsEmpty(coordinate) ? Error.SquareIsOccupied : Error.Null;
    }

    protected internal void MoveToken()
    {
        Coordinate origin;
        Error error;
        do
        {
            origin = GetCoordinate(Message.EnterOriginCoordinateToMove);
            error = CheckOriginErrorToMoveToken(origin);
        } while (!error.IsNull());

        Coordinate target;
        do
        {
            target = GetCoordinate(Message.EnterTargetCoordinateToMove);
            error = CheckTargetErrorToMoveToken(origin, target);
        } while (!error.IsNull());

        _board.MoveToken(origin, target);
    }

    private protected virtual Error CheckOriginErrorToMoveToken(Coordinate origin)
    {
        Debug.Assert(origin != null);

        if (_board.IsEmpty(origin))
        {
            return Error.SquareIsEmpty;
        }
        if (!_board.IsOccupied(_token, origin))
        {
            return Error.TokenIsNotOfCurrentPlayer;
        }

        return Error.Null;
    }

    private protected virtual Error CheckTargetErrorToMoveToken(Coordinate origin, Coordinate target)
    {
        Debug.Assert((origin != null) && (target != null));

        if (!_board.IsEmpty(origin))
        {
            return Error.SquareIsOccupied;
        }
        if (origin.Equals(target))
        {
            return Error.SquareCannotBeSameCoordinate;
        }

        return Error.Null;
    }

    protected internal bool IsContinue()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(Message.Resume.GetToString());
        return yesNoDialog.IsAffirmative();
    }

    protected internal void WriteWinner()
    {
        Message.WinnerMessage.WriteLine(_token.GetString());
    }
}