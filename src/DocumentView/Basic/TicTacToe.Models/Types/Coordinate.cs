namespace TicTacToe.Models.Types;

public class Coordinate
{
    public const int Dimension = 3;

    private readonly int _row;
    private readonly int _column;

    public Coordinate()
    {
    }

    public Coordinate(int row, int column)
    {
        _row = row;
        _column = column;
    }

    public int Row { get => _row; }

    public int Column { get => _column; }

    internal Error CheckErrorToValidCoordinate(Coordinate coordinate)
    {
        return
            !new ClosedInterval(min: 0, max: Coordinate.Dimension - 1).IsValid(value: coordinate.Row) &&
            !new ClosedInterval(min: 0, max: Coordinate.Dimension - 1).IsValid(value: coordinate.Column) ? Error.InvalidCoordinate : Error.Null;
    }

    public bool Equals(Coordinate coordinate)
    {
        return _row.Equals(coordinate.Row) && _column.Equals(coordinate.Column);
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
        if (InInverseDiagonal() && coordinate.InInverseDiagonal())
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
