using TicTacToe.ConsoleApp.Views.Models;
using TicTacToe.ConsoleApp.Views.Models.Players;
using TicTacToe.Controllers;
using TicTacToe.Types;

namespace TicTacToe.ConsoleApp.Views;

internal class PlayView
{
    internal void Interact(PlayController playController)
    {
        PlayerView playerView = PlayerViewPrototype.Instance.Create(playController);

        do
        {
            playController.Next();

            playerView.Interact();

            new BoardView().Show(playController);

        } while (!playController.IsTicTacToe());

        new MessageView().WriteLine(GameViews.Message.WinnerMessage, playController.GetCurrentToken().ToString());
    }
}
