using TicTacToe.GameViews;
using TicTacToe.Models;
using TicTacToe.Models.Types;

namespace TicTacToe.ConsoleApp.Views.Models.PlayModels;

internal class PlayerCreateView
{
    internal int Read(Game game)
    {
        int players;
        Error error;
        do
        {
            players = ConsoleIO.Instance.ReadInt(Message.SelectNumberPlayer.GetMessage());
            error = game.CheckErrorToReadPlayers(players);
            new ErrorView(error).WriteLine();
        } while (!error.IsNull());

        return players;
    }
}
