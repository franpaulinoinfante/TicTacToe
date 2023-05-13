using TicTacToe.GameViews;

namespace TicTacToe.WinFormApp;

internal class MainPresenter : TicTacToe
{
    private readonly IGameView _gameView;

    public MainPresenter(IGameView gameView)
    {
        _gameView = gameView;
    }

    protected override IGameView CreateGameView()
    {
        return _gameView;
    }
}
