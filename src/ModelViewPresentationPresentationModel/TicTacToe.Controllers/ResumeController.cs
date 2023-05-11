using TicTacToe.Models;

namespace TicTacToe.Controllers;

public class ResumeController : Controller
{
    public ResumeController(Game game, State state) : base(game, state)
    {
    }

    public override void Accept(IControllerVisitor visitor)
    {
        visitor.Visit(this);
    }
}