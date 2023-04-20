using System.Diagnostics;

internal abstract class Player
{
    private const int MaxToken = 3;
    private const int Empty = 0;

    private readonly Token _token;
    private readonly Board _board;

    private int _tokens;

    public Player(Token token, Board board)
    {
        _token = token;
        _board = board;
        _tokens = Player.MaxToken;
    }

    public Token Token
    {
        get
        {
            return _token;
        }
    }

    internal void Reset()
    {
        _tokens = Player.MaxToken;
    }

    internal bool HasToken()
    {
        return _tokens > Player.Empty;
    }

    internal void PutToken()
    {
        Debug.Assert(_board != null);
        Debug.Assert(HasToken());

        Coordinate target;
        Error error;
        do
        {
            target = GetCoordinate(Message.EnterCoordinateToPut);
            error = FindErrorToPutToken(target);
        } while (!error.IsNull());

        _board.PutToken(target, _token);
        _tokens--;
    }

    protected abstract Coordinate GetCoordinate(Message message);


    private protected virtual Error FindErrorToPutToken(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        if (!_board.IsEmpty(coordinate))
        {
            return Error.SquareIsOccupied;
        }

        return Error.Null;
    }

    internal void MoveToken()
    {
        Coordinate origin;
        Error error;
        do
        {
            origin = GetCoordinate(Message.EnterOriginCoordinateToMove);
            error = FindOriginErrorToMoveToken(origin);
        } while (!error.IsNull());

        Coordinate target;
        do
        {
            target = GetCoordinate(Message.EnterTargetCoordinateToMove);
            error = FindTargetErrorToMoveToken(origin, target);
        } while (!error.IsNull());

        _board.MoveToken(origin, target);
    }

    private protected virtual Error FindOriginErrorToMoveToken(Coordinate origin)
    {
        if (_board.IsEmpty(origin))
        {
            return Error.SquareIsEmpty;
        }

        if (!_board.IsOccupied(origin, _token))
        {
            return Error.NotOwnerToken;
        }

        return Error.Null;
    }

    private protected virtual Error FindTargetErrorToMoveToken(Coordinate origin, Coordinate target)
    {
        if (origin.Equals(target))
        {
            return Error.OriginAndTargetSquareCannotBeSame;
        }

        if (!_board.IsEmpty(target))
        {
            return Error.SquareIsOccupied;
        }

        return Error.Null;
    }

    internal void WriteWinnerMess()
    {
        Message.WinnerMessage.WriteLine(_token.GetToString());
    }

    internal bool IsContinue()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(Message.Resume.GetToString());
        return yesNoDialog.IsAffirmative();
    }
}