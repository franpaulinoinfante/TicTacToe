using TicTacToe.Types;

namespace TicTacToe.ConsoleApp.Views.Models;

internal class TokenView
{
    internal void Write(Token token)
    {
        if (token.IsNull())
        {
            ConsoleIO.Instance.Write(' ');
        }

        ConsoleIO.Instance.Write(token.ToString());
    }
}