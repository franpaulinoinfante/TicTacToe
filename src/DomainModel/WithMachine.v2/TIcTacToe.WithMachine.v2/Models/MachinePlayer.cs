internal class MachinePlayer : Player
{
    public MachinePlayer(Token token, Board board) : base(token, board)
    {
    }

    protected override Coordinate GetCoordinate(Message message)
    {
        throw new NotImplementedException();
    }
}
