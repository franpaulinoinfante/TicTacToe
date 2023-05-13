using TicTacToe.Controllers;
using TicTacToe.GameViews;

namespace TicTacToe;

public abstract class TicTacToe
{
    private readonly Logic _logic;
    private readonly IGameView _gameView;

    public TicTacToe()
    {
        _logic = new Logic();
        _gameView = CreateGameView();
    }

    protected abstract IGameView CreateGameView();

    public void Play()
    {
        Controller controller;
        do
        {
            controller = _logic.Controller;
            controller?.Accept(_gameView);
        } while (controller != null);
    }
}
