using TicTacToe.GameViews;
using TicTacToe.Models;
using TicTacToe.Models.Types;

namespace TicTacToe.ConsoleApp.Views.Models.PlayModels;

internal class MachinePlayerView : PlayerView
{
    protected override Coordinate Read(Message message, Game game)
    {
        ConsoleIO.Instance.WriteLine(message.GetMessage());
        return new CoordinateView().ReadRandom();
    }
}