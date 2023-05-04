using TicTacToe.GameViews;
using TicTacToe.Models.Types;

namespace TicTacToe.ConsoleApp.Views.Models;

internal class ErrorView : GameViews.ErrorView
{
    public ErrorView(Error error) : base(error)
    {
    }

    internal void WriteLine()
    {
        if (!_error.IsNull())
        {
            ConsoleIO.Instance.NewLine();
            MessageView messageView = new MessageView(Message.VerticalLine);
            messageView.WriteLine();
            messageView.WriteLine(Message.ErrorTitle);
            ConsoleIO.Instance.WriteLine(_errorMessages[(int)_error]);
            messageView.WriteLine(Message.VerticalLine);
            ConsoleIO.Instance.NewLine();
        }
    }
}
