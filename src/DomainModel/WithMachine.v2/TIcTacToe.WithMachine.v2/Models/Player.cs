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
        return _token == Player.Empty;
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


    private Error FindErrorToPutToken(Coordinate coordinate)
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
        throw new NotImplementedException();
    }
}