namespace TicTacToe.Models.Types;

public class Coordinate
{
    public const int Dimension = 3;

    private readonly int _row;
    private readonly int _column;

    public Coordinate(int row, int column)
    {
        _row = row;
        _column = column;
    }

    public int Row { get => _row; }

    public int Column { get => _column; }
}
