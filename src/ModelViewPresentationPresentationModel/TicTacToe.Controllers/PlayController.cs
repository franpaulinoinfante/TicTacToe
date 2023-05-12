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
        return Game.GetPlayerType();
    }

    public bool IsTicTacToe()
    {
        return Game.IsTicTacToe();
    }

    public Token GetCurrentTokenFromTurn()
    {
        return Game.GetCurrentTokenFromTurn();
    }

    public bool HasToken()
    {
        return Game.HasToken();
    }

    public void PutToken(Coordinate coordinate)
    {
        Game.PutToken(coordinate);
    }

    public Error FindToPutTokenError(Coordinate coordinate)
    {
        return Game.FindToPutTokenError(coordinate);
    }

    public void MoveToken(Coordinate[] coordinates)
    {
        Game.MoveToken(coordinates);
    }

    public Error FindOriginToMoveError(Coordinate coordinate)
    {
        return Game.FindOriginToMoveError(coordinate);
    }

    public Error FindTargetToMoveError(Coordinate[] coordinates)
    {
        return Game.FindTargetToMoveError(coordinates);
    }

    public void NextTurn()
    {
        Game.NextTurn();
    }
}