using TicTacToe.GameViews;

namespace TicTacToe.ConsoleApp.Views.Models;
internal class MessageView
{
    private readonly Message _title;

    public MessageView(Message title)
    {
        _title = title;
    }

    internal void Write(string title)
    {
        ConsoleIO.Instance.Write(_title.GetMessage().Replace("#token", title));
    }

    internal void WriteLine()
    {
        ConsoleIO.Instance.WriteLine(_title.GetMessage());
    }
}