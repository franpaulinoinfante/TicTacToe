using System.Diagnostics;

internal class Coordinate
{
    internal const int Dimension = 3;

    private int _row;
    private int _colunm;

    public Coordinate(){}

    public Coordinate(int row, int colunm)
    {
        _row = row;
        _colunm = colunm;
    }

    public int Row { get => _row; }

    public int Colunm { get => _colunm; }

    public bool Equals(Coordinate other)
    {
        Debug.Assert(other != null);

        return _row == other.Row && _colunm == other.Colunm;
    }

    internal Coordinate Read(string title)
    {
        ConsoleIO consoleIO = ConsoleIO.Instance;
        Error error;
        do
        {
            consoleIO.WriteLine(title);
            _row = consoleIO.ReadInt(Message.Row.GetString()) - 1;
            _colunm = consoleIO.ReadInt(Message.Colunm.GetString()) - 1;
            error = GetErrorToReadCoordinate();
            error.WriteLine();
        } while (!error.IsNull());

        return this;
    }

    private Error GetErrorToReadCoordinate()
    {
        if (!new Interval(min: 0, Coordinate.Dimension - 1).IsIncluide(_row) || !new Interval(min: 0, Coordinate.Dimension - 1).IsIncluide(_colunm))
        {
            return Error.SquareIsOutOfRange;
        }

        return Error.Null;
    }

    internal Direction GetDirection(Coordinate coordinate)
    {
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
        return _row == coordinate.Row;
    }

    private bool InVertical(Coordinate coordinate)
    {
        return _colunm == coordinate.Colunm;
    }

    private bool InMainDiagonal()
    {
        return _row - _colunm == 0;
    }

    private bool InInverseDiagonal()
    {
        return _row + _colunm == Coordinate.Dimension - 1;
    }
}
