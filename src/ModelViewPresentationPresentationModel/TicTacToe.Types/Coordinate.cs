namespace TicTacToe.Types;

public class Coordinate
{
    public const int Dimension = 3;

    public Coordinate()
    {
    }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }

    public int Column { get; }

    public bool isValid()
    {
        return
            new ClosedInterval(min: 0, Coordinate.Dimension - 1).IsInclude(Row) &&
            new ClosedInterval(min: 0, Coordinate.Dimension - 1).IsInclude(Column);
    }

    public bool Equals(Coordinate other)
    {
        return Row == other.Row && Column == other.Column;
    }

    public Direction GetDirection(Coordinate coordinate)
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
        return Row == coordinate.Row;
    }

    private bool InVertical(Coordinate coordinate)
    {
        return Column == coordinate.Column;
    }

    private bool InMainDiagonal()
    {
        return Row - Column == 0;
    }

    private bool InInverseDiagonal()
    {
        return Row + Column == Coordinate.Dimension - 1;
    }
}
