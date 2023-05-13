using TicTacToe.GameViews;
using TicTacToe.Types;

namespace TicTacToe.ConsoleApp.Views.Models;

internal class GameModeView
{
    internal GameMode ReadGameMode()
    {
        int gameModeValue = default;
        Error error;
        do
        {
            new MessageView().WriteLine(Message.GameModePlayersDetails);
            gameModeValue = ConsoleIO.Instance.ReadInt(Message.SelectGameModePlayers.GetMessage());
            error = FindSelectedGameModeError(gameModeValue);
            new ErrorView().Show(error);
        } while (!error.IsNull());

        return Enum.GetValues<GameMode>()[gameModeValue];
    }

    private Error FindSelectedGameModeError(int gameMode)
    {
        if ((((int)GameMode.MachineVsMachine) > gameMode) || (gameMode > (int)GameMode.PlayerVsPlayer))
        {
            return Error.InvalidGameMode;
        }

        return Error.Null;
    }
}
