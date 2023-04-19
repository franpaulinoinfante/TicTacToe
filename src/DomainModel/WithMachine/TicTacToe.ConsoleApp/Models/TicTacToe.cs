using TicTacToe.ConsoleApp.Models.Players;

namespace TicTacToe.ConsoleApp.Models;

internal class TicTacToe
{
    private readonly Board _board;
    private Player[] _players;
    private readonly Turn _turn;

    public TicTacToe()
    {
        _board = new Board();
        _turn = new Turn();
        _players = new Player[Turn.PlayersNumber];
    }

    internal void Run()
    {
        do
        {
            ConsoleIO.Instance.Clear();
            Message.TicTacToe.WriteLine();
            ConfigurePlayers();
            Start();
            Play();
        } while (IsResume());
    }

    private void ConfigurePlayers()
    {
        _players = new PlayerConfiguration().Configure(_board);
        _turn.Player = _players;
    }

    private void Start()
    {
        _board.Reset();
        _board.Write();

        for (int i = 0; i < Turn.PlayersNumber; i++)
        {
            _players[(int)_turn.Current.Token].Reset();
        }
    }

    private void Play()
    {
        do
        {
            _turn.Next();
            _turn.WriteLine();

            if (_players[(int)_turn.Current.Token].HasToken())
            {
                _players[(int)_turn.Current.Token].PutToken();
            }
            else
            {
                _players[(int)_turn.Current.Token].MoveToken();
            }

            _board.Write();
        } while (!_board.IsTicTacToe(_turn.Current.Token));

        _players[(int)_turn.Current.Token].WriteWinner();
    }

    private bool IsResume()
    {
        return _players[(int)_turn.Current.Token].IsContinue();
    }
}