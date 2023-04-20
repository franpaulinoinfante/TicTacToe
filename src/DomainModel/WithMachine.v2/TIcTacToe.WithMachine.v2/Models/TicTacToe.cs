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

    private Player Player
    {
        get
        {
            return _players[_turn.Current];
        }
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
        new PlayerConfiguration().Configure(_players, _board);
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
        do
        {
            _turn.Next();
            _turn.Write();

            if (Player.HasToken())
            {
                Player.PutToken();
            }
            else
            {
                Player.MoveToken();
            }

            _board.Write();
        } while (!_board.IsTicTacToe(Player.Token));

        Player.WriteWinnerMess();
    }

    private bool IsResume()
    {
        return Player.IsContinue();
    }
}