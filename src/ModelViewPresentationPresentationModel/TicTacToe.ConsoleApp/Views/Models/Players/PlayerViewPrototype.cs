using TicTacToe.Controllers;
using TicTacToe.Types;

namespace TicTacToe.ConsoleApp.Views.Models.Players;

internal class PlayerViewPrototype
{
    private static readonly PlayerViewPrototype? _instance;

    private PlayerViewPrototype() { }

    internal static PlayerViewPrototype Instance
    {
        get
        {
            return _instance ?? new PlayerViewPrototype();
        }
    }

    internal PlayerView CreatePlayerView(PlayController playController)
    {
        return playController.GetPlayerType() == PlayerType.UserPlayer
            ? new UserPlayerView(playController)
            : new MachinePlayerView(playController);

    }
}
