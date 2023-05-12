using TicTacToe.ConsoleApp.Views.Models;
using TicTacToe.Controllers;
using TicTacToe.GameViews;

namespace TicTacToe.ConsoleApp.Views;

internal class StartView
{
    internal void Interact(StartController startController)
    {
        new MessageView().WriteLine(Message.Title);

        startController.SetGameMode(new GameModeView().ReadGameMode());

        ConsoleIO.Instance.NewLine();

        new BoardView().Show(startController);

        startController.NextState();
    }
}
