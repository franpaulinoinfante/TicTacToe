internal class TicTacToe
{
    private readonly Board _board;
    private readonly Player[] _players;
    private readonly Turn _turn;

    public TicTacToe()
    {
        _board = new Board();
        _players = new Player[Turn.MaxPlayers];
        _turn = new Turn(_players, _board);
    }

    private Player Player()
    {
        return _turn.GetCurrent();
    }

    internal void Init()
    {
        do
        {
            Start();
            Play();
        } while (IsResume());

        Message.Goodbye.WriteLine();
        Task.Delay(400);
    }

    private void Start()
    {
        Message.TicTacToe.WriteLine();
        NewGame();
        _board.Write();
    }

    private void NewGame()
    {
        _board.Reset();
        for (int i = 0; i < _players.Length; i++)
        {
            _players[i].Reset();
        }
    }

    private void Play()
    {
        do
        {
            _turn.Next();
            Message.CurrentTurn.WriteLine(_players[(int)Player().GetToken()].GetToken().ToString());
            if (_players[(int)Player().GetToken()].HasToken())
            {
                _players[(int)Player().GetToken()].PutToken();
            }
            else
            {
                _players[(int)Player().GetToken()].MoveToken();
            }

            _board.Write();
        } while (!_board.IsTicTacToe(Player().GetToken()));

        Message.WinnerMessage.WriteLine(Player().GetToken().ToString());
    }

    private bool IsResume()
    {
        return _players[(int)Player().GetToken()].IsContinue();
    }
}