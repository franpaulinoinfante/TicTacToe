using TicTacToe.Controllers;
using TicTacToe.GameViews;

namespace TicTacToe.ConsoleApp.Views;
internal class ConsoleView : IGameView
{
    private readonly StartView _startView;
    private readonly PlayView _playView;

    public ConsoleView()
    {
        _startView = new StartView();
        _playView = new PlayView();
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
        throw new NotImplementedException();
    }
}