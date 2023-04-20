internal class Coordinate
{
    public const int Dimension = 3;

    private int _row;
    private int _colunm;

    public Coordinate()
    {
    }

    public Coordinate(int row, int colunm)
    {
        _row = row;
        _colunm = colunm;
    }

    internal int Row { get => _row; }

    internal int Colunm { get => _colunm; }

    internal void Read(Message message)
    {
        message.WriteLine();

        ConsoleIO consoleIO = ConsoleIO.Instance;
        _row = consoleIO.ReadInt(Message.Row.GetToString()) - 1;
        _colunm = consoleIO.ReadInt(Message.Colunm.GetToString()) - 1;
    }
}
