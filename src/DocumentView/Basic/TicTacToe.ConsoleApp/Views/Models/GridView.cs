using TicTacToe.GameViews;
using TicTacToe.Models;
using TicTacToe.Models.Types;

namespace TicTacToe.ConsoleApp.Views.Models;

internal class GridView
{
    internal void Clear()
    {
        ConsoleIO.Instance.Clear();
    }

    internal void Show(Game game)
    {
        MessageView messageView = new MessageView(Message.VerticalLine);

        ConsoleIO.Instance.NewLine();
        messageView.WriteLine();
        for (int i = 0; i < Coordinate.Dimension; i++)
        {
            for (int j = 0; j < Coordinate.Dimension; j++)
            {
                new TokenView().Write(game.GetToken(new Coordinate(i, j)));
            }
            ConsoleIO.Instance.NewLine();
        }
        messageView.WriteLine();
    }
}