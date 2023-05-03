using TicTacToe.Models;

namespace TicTacToe.GameViews;

public interface IWithGameView
{
    public Game Game { get; }
}
