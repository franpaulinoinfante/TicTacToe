using TicTacToe.Controllers;
using TicTacToe.GameViews;

namespace TicTacToe.ConsoleApp.Views;
internal class ConsoleView : IGameView
{
    private readonly StartView _startView;

    public ConsoleView()
    {
        _startView = new StartView();
    }

    public void Visit(StartController startController)
    {
        _startView.Interact(startController);
    }

    public void Visit(PlayController startController)
    {
        throw new NotImplementedException();
    }

    public bool Visit(ResumeController resumeController)
    {
        throw new NotImplementedException();
    }
}