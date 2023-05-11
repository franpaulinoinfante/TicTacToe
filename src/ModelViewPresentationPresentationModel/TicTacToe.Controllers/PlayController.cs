using TicTacToe.Models;
using TicTacToe.Types;

namespace TicTacToe.Controllers;

public class PlayController : Controller
{
    public PlayController(Game game, State state) : base(game, state)
    {
    }

    public override void Accept(IControllerVisitor visitor)
    {
        visitor.Visit(this);
    }

    public PlayerType GetPlayerType()
    {
        throw new NotImplementedException();
    }

    public bool IsTicTacToe()
    {
        throw new NotImplementedException();
    }

    public Token GetCurrentToken()
    {
        return Token.X;
    }

    public bool HasToken()
    {
        throw new NotImplementedException();
    }

    public void PutToken(Coordinate coordinate)
    {
        throw new NotImplementedException();
    }

    public Error FindToPutTokenError(Coordinate coordinate)
    {
        throw new NotImplementedException();
    }

    public void MoveToken(Coordinate[] coordinates)
    {
        throw new NotImplementedException();
    }

    public Error FindOrigiToMoveError(Coordinate coordinate)
    {
        throw new NotImplementedException();
    }

    public Error FindTargetToMoveError(Coordinate[] coordinates)
    {
        throw new NotImplementedException();
    }
}