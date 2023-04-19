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
        message.WriteLine();

        Error error;
        do
        {
            _row = ConsoleIO.Instance.ReadInt(Message.Row.GetString()) - 1;
            _column = ConsoleIO.Instance.ReadInt(Message.Colunm.GetString()) - 1;
            error = CheckErrorToReadCoordinate();
            error.WriteLine();
        } while (!error.IsNull());

        ConsoleIO.Instance.WriteLine();
    }

    internal void ReadRandom(Message message)
    {
        message.WriteLine();

        Random random = new Random();
        _row = random.Next(minValue: 0, maxValue: 3);
        _column = random.Next(minValue: 0, maxValue: 3);

        Task.Delay(400).Wait();
    }

    private Error CheckErrorToReadCoordinate()
    {
        if ((!new ClosedInterval(min: 0, Coordinate.Dimension - 1).IsIncluide(value: _row)) || 
            (!new ClosedInterval(min: 0, Coordinate.Dimension - 1).IsIncluide(value: _column)))
        {
            return Error.SquareIsOutOfRange;
        }

        return Error.Null;
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