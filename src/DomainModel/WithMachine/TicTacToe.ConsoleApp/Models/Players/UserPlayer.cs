using TicTacToe.ConsoleApp.Models.Enums;

namespace TicTacToe.ConsoleApp.Models.Players;

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

    private protected override Error CheckErrorToPuToken(Coordinate coordinate)
    {
        Error error = base.CheckErrorToPuToken(coordinate);
        error.WriteLine();
        return error;
    }

    private protected override Error CheckOriginErrorToMoveToken(Coordinate origin)
    {
        Error error = base.CheckOriginErrorToMoveToken(origin);
        error.WriteLine();
        return error;
    }

    private protected override Error CheckTargetErrorToMoveToken(Coordinate origin, Coordinate target)
    {
        Error error = base.CheckTargetErrorToMoveToken(origin, target);
        error.WriteLine();
        return error;
    }
}
