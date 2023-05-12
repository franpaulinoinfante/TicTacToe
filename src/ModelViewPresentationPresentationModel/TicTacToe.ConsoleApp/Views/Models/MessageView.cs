using TicTacToe.GameViews;

namespace TicTacToe.ConsoleApp.Views.Models;

internal class MessageView
{
    internal void Write(Message message)
    {
        ConsoleIO.Instance.Write(message.GetMessage());
    }

    internal void WriteLine(Message message)
    {
        ConsoleIO.Instance.WriteLine(message.GetMessage());
    }

    internal void WriteLine(Message message, string token)
    {
        ConsoleIO.Instance.WriteLine(message.GetMessage().Replace("#player", token));
    }
}
