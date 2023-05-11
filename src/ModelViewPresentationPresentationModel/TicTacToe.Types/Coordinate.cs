namespace TicTacToe.Types;

public class Coordinate
{
    public Coordinate()
    {
    }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public static int Dimension { get; set; }
    public int Row { get; set; }

    public int Column { get; set; }
}
