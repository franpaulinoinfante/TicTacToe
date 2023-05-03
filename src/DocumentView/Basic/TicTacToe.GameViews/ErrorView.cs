using TicTacToe.Models.Types;

namespace TicTacToe.GameViews;

public abstract class ErrorView
{
    protected Error _error;

    protected static string[] _errorMessages = new string[] 
    {
        "Invalid number of players"
    };

    public ErrorView(Error error)
    {
        _error = error;
    }
}
