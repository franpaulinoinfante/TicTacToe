using TicTacToe.ConsoleApp.Models.Enums;
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
        _players = new Player[Turn.MaxPlayers];
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

        for (int i = 0; i < Turn.MaxPlayers; i++)
        {
            _players[(int)GetCurrentPlayer()].Reset();
        }
    }

    private Token GetCurrentPlayer()
    {
        return _turn.Current.Token;
    }

    private void Play()
    {
        do
        {
            _turn.Next();
            _turn.WriteLine();

            if (_players[(int)GetCurrentPlayer()].HasToken())
            {
                _players[(int)GetCurrentPlayer()].PutToken();
            }
            else
            {
                _players[(int)GetCurrentPlayer()].MoveToken();
            }

            Array.Find(_players, x => x.Token == _turn.Current.Token);

            _board.Write();
        } while (!_board.IsTicTacToe(GetCurrentPlayer()));

        _players[(int)GetCurrentPlayer()].WriteWinner();
    }

    private bool IsResume()
    {
        return _players[(int)GetCurrentPlayer()].IsContinue();
    }
}