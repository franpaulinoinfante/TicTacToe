using TicTacToe.ConsoleApp.Views.Models;
using TicTacToe.ConsoleApp.Views.Models.Players;
using TicTacToe.Controllers;

namespace TicTacToe.ConsoleApp.Views;

internal class PlayView
{
    internal void Interact(PlayController playController)
    {
        do
        {
            playController.NextTurn();

            PlayerViewPrototype.Instance.CreatePlayerView(playController).Interact();

            new BoardView().Show(playController);
        } while (!playController.IsTicTacToe());

        new MessageView().WriteLine(GameViews.Message.WinnerMessage, playController.GetCurrentTokenFromTurn().ToString());

        playController.NextState();
    }
}
