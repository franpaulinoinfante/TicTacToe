using TicTacToe.GameViews;

namespace TicTacToe.WinFormsApp;

internal class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        TicTacToe ticTacToe = new TicTacToe();
        IGameView _gameView = new DashBoard(ticTacToe);
        ticTacToe.GameView = _gameView;

        Application.Run((Form)_gameView);
    }
}