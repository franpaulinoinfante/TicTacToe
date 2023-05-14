using TicTacToe.Types;

namespace TicTacToe.ConsoleApp.Views.Models;
internal class ErrorView : GameViews.ErrorView
{
    public override void Show(Error error)
    {
        if (!error.IsNull())
        {
            MessageView messageView = new();

            messageView.WriteLine(GameViews.Message.HorizontalLine);
            messageView.WriteLine(GameViews.Message.ErrorTitle);

            ConsoleIO.Instance.WriteLine(ErrorMessages[(int)error]);

            messageView.WriteLine(GameViews.Message.HorizontalLine);
            ConsoleIO.Instance.NewLine();
        }
    }
}
