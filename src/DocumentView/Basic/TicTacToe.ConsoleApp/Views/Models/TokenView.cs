using TicTacToe.Models.Types;

namespace TicTacToe.ConsoleApp.Views.Models;

internal class TokenView
{
    private readonly string[] _tokens = new string[]
    {
        "X",
        "O",
        " "
    };

    internal void Write(Token token)
    {
        new MessageView(GameViews.Message.Square).Write(_tokens[(int)token]);
    }
}