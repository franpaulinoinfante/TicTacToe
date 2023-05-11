using TicTacToe.Controllers;

namespace TicTacToe.ConsoleApp.Views.Models.Players;

internal class MachinePlayerView : PlayerView
{
    private PlayController _playController;

    public MachinePlayerView(PlayController playController)
    {
        _playController = playController;
    }
}