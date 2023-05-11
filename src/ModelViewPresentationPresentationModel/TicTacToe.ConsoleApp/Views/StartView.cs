using TicTacToe.ConsoleApp.Views.Models;
using TicTacToe.Controllers;
using TicTacToe.GameViews;

namespace TicTacToe.ConsoleApp.Views;

internal class StartView
{
    internal void Interact(StartController startController)
    {
        startController.SetGameModePlayers(new GameModePlayerView().Read(startController));

        new MessageView().WriteLine(Message.Title);

        new BoardView().Show(startController);

        startController.Next();
    }
}
