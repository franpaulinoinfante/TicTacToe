using TicTacToe.ConsoleApp.Views;
using TicTacToe.GameViews;

internal class Program : TicTacToe.TicTacToe
{
    protected override IGameView CreateGameView()
    {
        return new ConsoleView();
    }

    private static void Main(string[] args)
    {
        new Program().Play();
    }
}