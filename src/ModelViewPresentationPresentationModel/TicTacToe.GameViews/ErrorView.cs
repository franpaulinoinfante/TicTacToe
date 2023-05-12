using TicTacToe.Types;

namespace TicTacToe.GameViews;

public abstract class ErrorView
{
    protected string[] ErrorMessages = new string[]
    {
        "Game mode is not valid.",
        "Coordinate is not valid.",
        "The square is occupied.",
        "The square is not empty.",
        "Token does not belong to you.",
        "The origin and target coordinate cannot be the same."
    };

    public abstract void Show(Error error);
}
