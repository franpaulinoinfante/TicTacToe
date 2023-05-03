using TicTacToe.ConsoleApp.Views.Models;
using TicTacToe.GameViews;
using TicTacToe.Models;

namespace TicTacToe.ConsoleApp.Views;

internal class StartView
{
    private readonly Game _game;

    public StartView(Game game)
    {
        _game = game;
    }

    internal void Interact()
    {
        new MessageView(Message.Title).WriteLine();
        new MessageView(Message.NumberPlayerMenu).WriteLine();

        _game.CreatePlayer(ConsoleIO.Instance.ReadInt(Message.SelectNumberPlayer.GetMessage()));
        _game.NewGame();

        new GridView().Show(_game);
    }
}
