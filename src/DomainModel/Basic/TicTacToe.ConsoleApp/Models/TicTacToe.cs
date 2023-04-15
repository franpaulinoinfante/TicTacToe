internal class TicTacToe
{
    private Board _board;
    private Player[] _players;
    private Turn _turn;

    public TicTacToe()
    {
        _board = new Board();
        _players = new Player[Turn.NumPlayers];
        _turn = new Turn(_players, _board);
    }

    internal void Init()
    {
        do
        {
            Start();
            Play();
        } while (Resume());

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
        _board.NewGame();
        for (int i = 0; i < _players.Length; i++)
        {
            _players[i].NewGame();
        }
    }

    private void Play()
    {
        do
        {
            _turn.Next();
            Message.CurrentTurn.WriteLine(_players[_turn.GetCurrentPlayer()].GetToken().ToString());
            if (_players[_turn.GetCurrentPlayer()].HasToken())
            {
                _players[_turn.GetCurrentPlayer()].PutToken();
            }
            else
            {
                _players[_turn.GetCurrentPlayer()].MoveToken();
            }

            _board.Write();
            var tokenss = _players[_turn.GetCurrentPlayer()].GetToken();
        } while (!_board.IsTicTacToe(_players[_turn.GetCurrentPlayer()].GetToken()));

        Message.WinnerMessage.WriteLine(_players[_turn.GetCurrentPlayer()].GetToken().ToString());
    }

    private bool Resume()
    {
        return _players[_turn.GetCurrentPlayer()].Continue();
    }
}