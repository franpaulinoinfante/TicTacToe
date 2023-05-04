using TicTacToe.Models.Types;

namespace TicTacToe.GameViews;

public abstract class ErrorView
{
    protected Error _error;

    protected static string[] _errorMessages = new string[]
    {
        "Invalid number of players",
        "The square is occupied",
        "The token does not belong to you",
        "The origin and destination coordinate cannot be the same",
        "The coordinate is invalid"
    };

    public ErrorView(Error error)
    {
        _error = error;
    }
}
