using TicTacToe.GameViews;

namespace TicTacToe.WinFormApp;

internal class Program
{
    [STAThread]
    private static void Main()
    {

        ApplicationConfiguration.Initialize();

        IMainView gameView = new Main();
        new MainPresenter(gameView);
        Application.Run((Form)gameView);
    }
}