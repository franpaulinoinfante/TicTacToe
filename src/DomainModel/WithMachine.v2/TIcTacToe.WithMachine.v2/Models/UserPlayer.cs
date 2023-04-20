internal class UserPlayer : Player
{
    public UserPlayer(Token token, Board board) : base(token, board)
    {
    }

    protected override Coordinate GetCoordinate(Message message)
    {
        Coordinate coordinate = new Coordinate();
        coordinate.Read(message);
        return coordinate;
    }

    private protected override Error FindErrorToPutToken(Coordinate coordinate)
    {
        Error error = base.FindErrorToPutToken(coordinate);
        error.WriteLine();
        return error;
    }

    private protected override Error FindOriginErrorToMoveToken(Coordinate origin)
    {
        Error error = base.FindOriginErrorToMoveToken(origin);
        error.WriteLine();
        return error;
    }

    private protected override Error FindTargetErrorToMoveToken(Coordinate origin, Coordinate target)
    {
        Error error = base.FindTargetErrorToMoveToken(origin, target);
        error.WriteLine();
        return error;
    }
}
