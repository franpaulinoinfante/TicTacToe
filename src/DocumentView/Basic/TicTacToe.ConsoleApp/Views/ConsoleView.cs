using TicTacToe.GameViews;
using TicTacToe.Models;

namespace TicTacToe.ConsoleApp.Views;

internal class ConsoleView : IGameView
{
    private readonly StartView _startView;

    public ConsoleView(Game game)
    {
        _startView = new StartView(game);
    }

    public bool IsResume()
    {
        throw new NotImplementedException();
    }

    public void Run()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        _startView.Interact();
    }
}