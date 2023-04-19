internal class Turn
{
    internal const int MaxPlayers = 2;

    private readonly Player[] _players;
    private int _current;

    public Turn(Player[] players, Board _board)
    {
        _players = players;
        for (int i = 0; i < Turn.MaxPlayers; i++)
        {
            _players[i] = new Player(Enum.GetValues<Token>()[i], _board);
        }

        _current = new Random().Next(minValue: 0, maxValue: 2);
    }

    internal int GetCurrentPlayer()
    {
        return _current;
    }

    internal Player GetCurrent()
    {
        return _players[_current];
    }

    internal void Next()
    {
        _current = (_current + 1) % Turn.MaxPlayers;
    }

    private int Changer()
    {
        return (_current + 1) % Turn.MaxPlayers;
    }
}