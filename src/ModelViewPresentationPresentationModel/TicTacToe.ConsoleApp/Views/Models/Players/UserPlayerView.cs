using TicTacToe.Controllers;
using TicTacToe.GameViews;
using TicTacToe.Types;

namespace TicTacToe.ConsoleApp.Views.Models.Players;

internal class UserPlayerView : PlayerView
{
    public UserPlayerView(PlayController playController) : base(playController)
    {
    }

    protected override Coordinate ReadCoordinateToPut()
    {
        Coordinate coordinate;
        Error error;
        do
        {
            new MessageView().WriteLine(Message.EnterCoordinateToPut);
            coordinate = new CoordinateView().Read();
            error = FindToPutTokenError(coordinate);
            new ErrorView().Show(error);
        } while (!error.IsNull());

        return coordinate;
    }

    protected override Coordinate[] ReadCoordinatesToMove()
    {
        Coordinate[] coordinates;
        Coordinate origin;
        Error error;
        do
        {
            new MessageView().WriteLine(Message.EnterOriginCoordinateToMove);
            origin = new CoordinateView().Read();
            error = FindOriginToMoveError(origin);
            new ErrorView().Show(error);
        } while (!error.IsNull());

        Coordinate target;
        do
        {
            new MessageView().WriteLine(Message.EnterTargetCoordinateToMove);
            target = new CoordinateView().Read();
            coordinates = new Coordinate[] { origin, target };
            error = FindTargetToMoveError(coordinates);
            new ErrorView().Show(error);
        } while (!error.IsNull());

        return coordinates;
    }
}