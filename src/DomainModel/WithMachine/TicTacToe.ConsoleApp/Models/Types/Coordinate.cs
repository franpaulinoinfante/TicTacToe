using System.Diagnostics;
using TicTacToe.ConsoleApp.Models.Enums;

internal class Coordinate
{
    internal const int Dimension = 3;

    private int _row;
    private int _column;

    public Coordinate() { }

    public Coordinate(int row, int column)
    {
        _row = row;
        _column = column;
    }

    public int Row { get => _row; }

    public int Column { get => _column; }

    internal void Read(Message message)
    {
        Error error;
        do
        {
            message.WriteLine();

            _row = ConsoleIO.Instance.ReadInt(Message.Row.GetToString()) - 1;
            _column = ConsoleIO.Instance.ReadInt(Message.Colunm.GetToString()) - 1;

            error = CheckErrorToReadCoordinate();
            error.WriteLine();
        } while (!error.IsNull());
    }

    private Error CheckErrorToReadCoordinate()
    {
        if ((!new ClosedInterval(min: 0, Coordinate.Dimension - 1).IsIncluide(_row)) || 
            (!new ClosedInterval(min: 0, Coordinate.Dimension - 1).IsIncluide(_column)))
        {
            return Error.SquareIsOutOfRange;
        }

        return Error.Null;
    }

    internal void ReadRandom()
    {

        Random random = new Random();
        _row = random.Next(minValue: 0, maxValue: 3);
        _column = random.Next(minValue: 0, maxValue: 3);
    }

    internal bool Equals(Coordinate other)
    {
        Debug.Assert(other != null);

        return (_row == other.Row) && (_column == other.Column);
    }

    internal Direction GetDirection(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        if (InHorizontal(coordinate))
        {
            return Direction.Horizontal;
        }
        if (InVertical(coordinate))
        {
            return Direction.Vertical;
        }
        if (InMainDiagonal() && coordinate.InMainDiagonal())
        {
            return Direction.MainDiagonal;
        }
        if (InInverseDiagonal())
        {
            return Direction.InverseDiagonal;
        }

        return Direction.Null;
    }

    private bool InHorizontal(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        return _row == coordinate.Row;
    }

    private bool InVertical(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        return _column == coordinate.Column;
    }

    private bool InMainDiagonal()
    {
        return _row - _column == 0;
    }

    private bool InInverseDiagonal()
    {
        return _row + _column == Coordinate.Dimension - 1;
    }
}