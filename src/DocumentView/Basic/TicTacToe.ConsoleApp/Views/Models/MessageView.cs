using TicTacToe.GameViews;

namespace TicTacToe.ConsoleApp.Views.Models;
internal class MessageView
{
    private readonly Message _message;

    public MessageView(Message message)
    {
        _message = message;
    }

    internal void Write(string title)
    {
        ConsoleIO.Instance.Write(_message.GetMessage().Replace("#token", title));
    }

    internal void WriteLine()
    {
        ConsoleIO.Instance.WriteLine(_message.GetMessage());
    }

    internal void WriteLine(Message message)
    {
        ConsoleIO.Instance.WriteLine(message.GetMessage());
    }

    internal void WriteLine(string player)
    {
        ConsoleIO.Instance.WriteLine(_message.GetMessage().Replace("#player", player));
    }
}