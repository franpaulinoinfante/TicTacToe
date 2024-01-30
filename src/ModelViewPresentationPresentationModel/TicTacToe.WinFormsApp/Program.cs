using TicTacToe.GameViews;
using TicTacToe.TicTacToeV2;

namespace TicTacToe.WinFormsApp;

internal static class Program 
{ 
    [STAThread]
    static void Main()
    {        
        ApplicationConfiguration.Initialize();

        IGameView gameView = new Form1();
        
        TicTacToeV2.TicTacToe ticTacToe = new TicTacToeV2.TicTacToe(gameView);

        (gameView as Form1).TicTacToe = ticTacToe;

        Application.Run((Form1)gameView);
    }
}