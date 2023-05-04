using TicTacToe.GameViews;
using TicTacToe.Models;

namespace TicTacToe.ConsoleApp.Views;

internal class ConsoleView : IGameView
{
    private readonly StartView _startView;
    private readonly PlayView _playView;

    public ConsoleView(Game game)
    {
        _startView = new StartView(game);
        _playView = new PlayView(game);
    }

    public void Start()
    {
        _startView.Interact();
    }

    public void Play()
    {
        _playView.Interact();
    }

    public bool IsResume()
    {
        throw new NotImplementedException();
    }
}