using System.Diagnostics;

internal class Player
{
    private const int MaxToken = 3;

    private readonly Token _token;
    private readonly Board _board;

    private int _tokenCount;

    public Player(Token token, Board board)
    {
        _token = token;
        _board = board;

        Reset();
    }

    internal void Reset()
    {
        _tokenCount = Player.MaxToken;
    }

    internal Token GetToken()
    {
        return _token;
    }

    internal bool HasToken()
    {
        return _tokenCount > 0;
    }

    internal void PutToken()
    {
        Coordinate coordinate;
        Error error;
        do
        {
            coordinate = new Coordinate().Read(Message.EnterCoordinateToPut.GetString());
            error = GetErrorToPutToken(coordinate);
            error.WriteLine();
        } while (!error.IsNull());

        _board.PutToken(coordinate, _token);
        _tokenCount = _tokenCount - 1;
    }

    private Error GetErrorToPutToken(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        if (!_board.IsEmpty(coordinate))
        {
            return Error.SquareIsEmpty;
        }

        return Error.Null;
    }

    internal void MoveToken()
    {
        Coordinate origin;
        Error error;
        do
        {
            origin = new Coordinate().Read(Message.EnterOriginCoordinateToMove.GetString());
            error = GetErrorToMoveOriginToken(origin);
            error.WriteLine();
        } while (!error.IsNull());

        Coordinate target;
        do
        {
            target = new Coordinate().Read(Message.EnterTargetCoordinateToMove.GetString());
            error = GetErrorToMoveTargetCoordinate(origin, target);
            error.WriteLine();
        } while (!error.IsNull());

        _board.Move(origin, target);
    }

    private Error GetErrorToMoveOriginToken(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        if (!_board.IsOccupied(coordinate, _token))
        {
            return Error.TokenIsNotOfCurrentPlayer;
        }

        return Error.Null;
    }

    private Error GetErrorToMoveTargetCoordinate(Coordinate origin, Coordinate target)
    {
        Debug.Assert(origin != null);

        if (origin.Equals(target))
        {
            return Error.SquareCannotBeSameCoordinate;
        }
        if (!_board.IsEmpty(target))
        {
            return Error.SquareIsOccupied;
        }

        return Error.Null;
    }

    internal bool IsContinue()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(Message.Resume.ToString());
        ConsoleIO.Instance.WriteLine();
        return yesNoDialog.IsAffirmative();
    }
}