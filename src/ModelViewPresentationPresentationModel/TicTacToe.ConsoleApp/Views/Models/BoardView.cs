using TicTacToe.Controllers;
using TicTacToe.GameViews;
using TicTacToe.Types;

namespace TicTacToe.ConsoleApp.Views.Models;
internal class BoardView
{
    internal void Show(Controller controller)
    {
        MessageView messageView = new MessageView();

        messageView.WriteLine(GameViews.Message.HorizontalLine);
        for (int i = 0; i < Coordinate.Dimension; i++)
        {
            for (int j = 0; j < Coordinate.Dimension; j++)
            {
                messageView.Write(Message.LeftSideOfSquare);
                new TokenView().Write(controller.GetToken(new Coordinate(i, j)));
                messageView.Write(Message.RightSideOfSquare);
            }
            ConsoleIO.Instance.NewLine();
        }
        messageView.WriteLine(Message.HorizontalLine);
        ConsoleIO.Instance.NewLine();
    }
}
