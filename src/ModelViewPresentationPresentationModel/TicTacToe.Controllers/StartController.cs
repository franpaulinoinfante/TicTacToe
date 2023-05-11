using TicTacToe.Models;

namespace TicTacToe.Controllers;

public class StartController : Controller
{
    public StartController(Game game, State state) : base(game, state)
    {
    }

    public override void Accept(IControllerVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void SetGameModePlayers(int numberOfPlayer)
    {
        Game.SetGameModePlayers(numberOfPlayer);
    }
}