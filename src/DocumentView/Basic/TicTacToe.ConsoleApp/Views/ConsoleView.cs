

using System.Diagnostics;
using TicTacToe.GameViews;
using TicTacToe.Models;

namespace TicTacToe.ConsoleApp.Views;

internal class ConsoleView : IGameView
{
    private readonly StartView _startView;
    private readonly PlayView _playView;
    private readonly ResumeView _resumeView;

    public ConsoleView(Game game)
    {
        Debug.Assert(game != null); 

        _startView = new StartView(game);
        _playView = new PlayView(game);
        _resumeView = new ResumeView(game);
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
        return _resumeView.Interact();
    }
}