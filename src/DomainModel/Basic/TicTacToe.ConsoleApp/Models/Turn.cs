internal class Turn
{
    internal const int NumPlayers = 2;

    private Player[] _players;
    private int _current;

    public Turn(Player[] players, Board _board)
    {
        _players = players;
        for (int i = 0; i < Turn.NumPlayers; i++)
        {
            _players[i] = new Player(Enum.GetValues<Token>()[i], _board);
        }

        _current = new Random().Next(minValue: 0, maxValue: 2);
    }

    internal int GetCurrentPlayer()
    {
        return _current;
    }

    internal void Next()
    {
        _current = (_current + 1) % Turn.NumPlayers;
    }

    private int Changer()
    {
        return (_current + 1) % Turn.NumPlayers;
    }
}