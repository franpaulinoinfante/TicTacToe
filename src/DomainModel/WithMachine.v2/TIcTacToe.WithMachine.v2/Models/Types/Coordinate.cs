using System.Diagnostics;

internal class Coordinate
{
    public const int Dimension = 3;

    private int _row;
    private int _column;

    public Coordinate()
    {
    }

    public Coordinate(int row, int colunm)
    {
        _row = row;
        _column = colunm;
    }

    internal int Row { get => _row; }

    internal int Column { get => _column; }

    internal void Read(Message message)
    {
        ConsoleIO consoleIO = ConsoleIO.Instance;
        Error error;
        do
        {
            message.WriteLine();

            _row = consoleIO.ReadInt(Message.Row.GetToString()) - 1;
            _column = consoleIO.ReadInt(Message.Colunm.GetToString()) - 1;

            error = FindErrorToCoordinateOutOfRange();
            error.WriteLine();
        } while (!error.IsNull());
    }

    private Error FindErrorToCoordinateOutOfRange()
    {
        if ((!new ClosedInterval(min: 0, Coordinate.Dimension - 1).IsIncluide(_row)) ||
            (!new ClosedInterval(min: 0, Coordinate.Dimension - 1).IsIncluide(_column)))
        {
            return Error.CoordinateIsOutOfRange;
        }

        return Error.Null;
    }

    internal void ReadRandom()
    {
        Task.Delay(450).Wait();

        Random random = new Random();
        _row = random.Next(minValue: 0, Coordinate.Dimension);
        _column = random.Next(minValue: 0, Coordinate.Dimension);
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
