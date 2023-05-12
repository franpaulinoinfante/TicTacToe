using TicTacToe.Controllers;
using TicTacToe.Types;

namespace TicTacToe.ConsoleApp.Views.Models.Players;

internal class MachinePlayerView : PlayerView
{
    public MachinePlayerView(PlayController playController) : base(playController)
    {
    }

    protected override Coordinate ReadCoordinateToPut()
    {
        Coordinate coordinate;
        Error error;
        do
        {
            coordinate = new CoordinateView().ReadRandom();
            error = FindToPutTokenError(coordinate);
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
            origin = new CoordinateView().ReadRandom();
            error = FindOriginToMoveError(origin);
        } while (!error.IsNull());

        Coordinate target;
        do
        {
            target = new CoordinateView().ReadRandom();
            coordinates = new Coordinate[] { origin, target };
            error = FindTargetToMoveError(coordinates);
        } while (!error.IsNull());

        return coordinates;
    }
}