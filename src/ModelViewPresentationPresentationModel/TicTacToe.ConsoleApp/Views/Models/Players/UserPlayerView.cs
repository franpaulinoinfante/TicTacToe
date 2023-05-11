using TicTacToe.Controllers;

namespace TicTacToe.ConsoleApp.Views.Models.Players;

internal class UserPlayerView : MachinePlayerView
{
    public UserPlayerView(PlayController playController) : base(playController)
    {
    }
}