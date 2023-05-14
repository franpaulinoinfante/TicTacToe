using TicTacToe.GameViews;

namespace TicTacToe.WinFormApp;

internal class MainPresenter : TicTacToe
{
    private readonly IMainView _gameView;

    public MainPresenter(IMainView gameView)
    {
        _gameView = gameView;

        gameView.btnOpenGame += OpenGame;
    }

    private void OpenGame(object? sender, EventArgs e)
    {
        Run();
    }

    protected override IGameView CreateGameView()
    {
        return _gameView;
    }


}
