using System.Diagnostics;

internal class TicTacToe
{
    private readonly Board _board;
    private readonly Turn _turn;
    private readonly Player[] _players;

    public TicTacToe()
    {
        _board = new Board();
        _players = new Player[Turn.MaxPlayer];
        _turn = new Turn(_players);
    }

    internal void Run()
    {
        do
        {
            ConsoleIO.Instance.Clear();
            Message.TicTacToe.WriteLine();
            ConfigurePlayer();
            Start();
            Play();
        } while (IsResume());
    }

    private void ConfigurePlayer()
    {
        new PlayerCreator().Configure(_players, _board);
    }

    private void Start()
    {
        for (int i = 0; i < Turn.MaxPlayer; i++)
        {
            _players[i].Reset();
        }

        _board.Reset();
        _board.Write();
    }

    private void Play()
    {
        _turn.Next();
        _turn.Write();

        do
        {
            if (_players[GetCurrent()].HasToken())
            {
                _players[GetCurrent()].PutToken();
            }
            else
            {
                _players[GetCurrent()].MoveToken();
            }

            _board.Write();
        } while (_board.IsTicTacToe(_players[GetCurrent()].Token));
    }

    private int GetCurrent()
    {
        return _turn.Current;
    }

    private bool IsResume()
    {
        throw new NotImplementedException();
    }
}