internal class Turn
{
    internal const int MaxPlayer = 2;
    private const int Zero = 0;


    private readonly Player[] _players;

    private int _current;

    public Turn(Player[] players)
    {
        _players = players;
        _current = 0;
    }

    public Player[] Players
    {
        get
        {
            return _players;
        }
    }

    public int Current { get => _current; }

    internal void Next()
    {
        _current = (_current + 1) % Turn.MaxPlayer;
    }

    internal void Write()
    {
        Message.CurrentTurn.WriteLine(_players[_current].Token.GetToString());
    }
}