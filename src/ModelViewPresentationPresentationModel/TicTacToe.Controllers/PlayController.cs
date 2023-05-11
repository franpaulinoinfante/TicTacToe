using TicTacToe.Models;

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
}