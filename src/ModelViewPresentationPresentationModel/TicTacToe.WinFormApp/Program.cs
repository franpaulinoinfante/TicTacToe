using TicTacToe.GameViews;

namespace TicTacToe.WinFormApp;

internal class Program 
{
    [STAThread]
    private static void Main()
    {

        ApplicationConfiguration.Initialize();

        IGameView gameView = new Main();
        new MainPresenter(gameView);
        Application.Run((Form)gameView);
    }
}