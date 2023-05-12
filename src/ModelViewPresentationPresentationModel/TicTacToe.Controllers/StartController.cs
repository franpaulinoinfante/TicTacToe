using TicTacToe.Models;
using TicTacToe.Types;

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

    public void SetGameMode(GameMode numberOfPlayer)
    {
        Game.SetGameModePlayers(numberOfPlayer);
    }
}