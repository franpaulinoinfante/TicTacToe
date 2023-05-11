using TicTacToe.Controllers;
using TicTacToe.GameViews;
using TicTacToe.Types;

namespace TicTacToe.ConsoleApp.Views.Models;

internal class GameModePlayerView
{
    internal int Read()
    {

        int numberOfPlayer = default;
        Error error;
        do
        {
            new MessageView().WriteLine(Message.GameModePlayersDetails);
            numberOfPlayer = ConsoleIO.Instance.ReadInt(Message.SelectGameModePlayers.GetMessage());
            error = FindSelectGameModeError(numberOfPlayer);
            new ErrorView().Show(error);
        } while (!error.IsNull());

        return numberOfPlayer;
    }

    private Error FindSelectGameModeError(int numberOfPlayer)
    {
        if (((int)PlayerType.MachinePlayer > numberOfPlayer) || (numberOfPlayer > (int)PlayerType.UserPlayer + 1))
        {
            return Error.InvalidGameMode;
        }

        return Error.Null;
    }
}
