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
}
