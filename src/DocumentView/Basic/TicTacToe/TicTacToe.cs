using TicTacToe.GameViews;
using TicTacToe.Models;

namespace TicTacToe;

public class TicTacToe
{
    private static Game _game;
    private IGameView _gameView;

    public TicTacToe()
    {
        //_game = new Game();
    }

    public Game Game { get => _game; }

    public IGameView GameView { set => _gameView = value; }

    public void Run()
    {
        do
        {
            _gameView.Start();
            _gameView.Play();
        } while (_gameView.IsResume());
    }
}
