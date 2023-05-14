using TicTacToe.GameViews;

namespace TicTacToe.WinFormApp;

internal interface IMainView : IGameView
{
    event EventHandler btnOpenGame;
}
