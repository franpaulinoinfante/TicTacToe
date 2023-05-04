using TicTacToe.GameViews;
using TicTacToe.Models;
using TicTacToe.Models.Types;

namespace TicTacToe.ConsoleApp.Views.Models.PlayModels;

internal class UserPlayerView : PlayerView
{
    protected override Coordinate Read(Message message, Game game)
    {
        return new CoordinateView().Read(message, game);
    }

    protected override Error CheckErrorToPut(Coordinate coordinate)
    {
        Error error = base.CheckErrorToPut(coordinate);
        new ErrorView(error).WriteLine();
        return error;
    }

    protected override Error CheckOriginErrorToMove(Coordinate origin)
    {
        Error error = base.CheckOriginErrorToMove(origin);
        new ErrorView(error).WriteLine();
        return error;
    }

    protected override Error CheckTargetErrorToMove(Coordinate origin, Coordinate target)
    {
        Error error = base.CheckTargetErrorToMove(origin, target);
        new ErrorView(error).WriteLine();
        return error;
    }
}