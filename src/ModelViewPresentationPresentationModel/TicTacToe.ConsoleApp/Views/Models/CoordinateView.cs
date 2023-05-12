using TicTacToe.Types;

namespace TicTacToe.ConsoleApp.Views.Models;

internal class CoordinateView
{
    private const string Row = "Row: ";
    private const string Column = "Column: ";

    internal Coordinate Read()
    {
        Coordinate coordinate;
        Error error;
        do
        {
            int row = ConsoleIO.Instance.ReadInt(CoordinateView.Row) - 1;
            int column = ConsoleIO.Instance.ReadInt(CoordinateView.Column) - 1;
            coordinate = new Coordinate(row, column);
            error = FindValidCoordinateError(coordinate);
            new ErrorView().Show(error);
        } while (!error.IsNull());

        return coordinate;
    }

    internal Coordinate ReadRandom()
    {
        Task.Delay(350).Wait();

        Random random = new();
        return
            new Coordinate(
                row: random.Next(minValue: 0, Coordinate.Dimension),
                column: random.Next(minValue: 0, Coordinate.Dimension));
    }

    private Error FindValidCoordinateError(Coordinate coordinate)
    {
        if (!coordinate.isValid())
        {
            return Error.InvalidCoordinate;
        }

        return Error.Null;
    }
}
