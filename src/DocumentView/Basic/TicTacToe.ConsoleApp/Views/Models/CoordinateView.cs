using TicTacToe.GameViews;
using TicTacToe.Models;
using TicTacToe.Models.Types;

namespace TicTacToe.ConsoleApp.Views.Models;

internal class CoordinateView
{
    private const string Row = "Row: ";
    private const string Column = "Column: ";

    internal Coordinate Read(Message message, Game game)
    {
        ConsoleIO consoleIO = ConsoleIO.Instance;
        Coordinate coordinate;
        Error error;
        do
        {
            consoleIO.WriteLine(message.GetMessage());

            int row = consoleIO.ReadInt(CoordinateView.Row) - 1;
            int column = consoleIO.ReadInt(CoordinateView.Column) - 1;
            coordinate = new Coordinate(row, column);
            error = game.CheckErrorToValidCoordinate(coordinate);
            new ErrorView(error).WriteLine();
        } while (!error.IsNull());

        return coordinate;        
    }

    internal Coordinate ReadRandom()
    {
        //Task.Delay(450).Wait();

        Random random = new Random();
        int row = random.Next(minValue: 0, maxValue: Coordinate.Dimension);
        int column = random.Next(minValue: 0, maxValue: Coordinate.Dimension);
        return new Coordinate(row, column);
    }
}