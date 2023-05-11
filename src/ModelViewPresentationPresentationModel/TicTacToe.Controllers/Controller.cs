using TicTacToe.Models;
using TicTacToe.Types;

namespace TicTacToe.Controllers;

public abstract class Controller
{
    private readonly Game _game;
    private readonly State _state;

    protected Controller(Game game, State state)
    {
        _game = game;
        _state = state;
    }

    protected Game Game { get => _game; }

    protected State State { get => _state; }

    public abstract void Accept(IControllerVisitor visitor);

    public Token GetToken(Coordinate coordinate)
    {
        throw new NotImplementedException();
    }

    public void Next()
    {
        _state.Next();
    }
}
