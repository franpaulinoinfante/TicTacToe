using TicTacToe.Controllers;
using TicTacToe.GameViews;

namespace TicTacToe.ConsoleApp.Views;
internal class ConsoleView : IGameView
{
    private readonly StartView _startView;
    private readonly PlayView _playView;
    private readonly ResumeView _resumeView;

    public ConsoleView()
    {
        _startView = new StartView();
        _playView = new PlayView();
        _resumeView = new ResumeView();
    }

    public void Visit(StartController startController)
    {
        _startView.Interact(startController);
    }

    public void Visit(PlayController playController)
    {
        _playView.Interact(playController);
    }

    public bool Visit(ResumeController resumeController)
    {
        return _resumeView.Interact(resumeController);
    }
}