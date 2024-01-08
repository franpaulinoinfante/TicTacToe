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

    public abstract void Accept(IControllerVisitor visitor);

    public void Reset()
    {
        _game.Reset();
        _state.Reset();
    }

    public Token GetToken(Coordinate coordinate)
    {
        return _game.GetToken(coordinate);
    }

    public void NextState()
    {
        _state.Next();
    }
}
