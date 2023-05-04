using TicTacToe.ConsoleApp.Views.Models;
using TicTacToe.ConsoleApp.Views.Models.PlayModels;
using TicTacToe.Models;
using TicTacToe.Models.Types;

namespace TicTacToe.ConsoleApp.Views;

internal class PlayView
{
    private Game _game;

    public PlayView(Game game)
    {
        _game = game;
    }

    internal void Interact()
    {
        do
        {
            _game.Next();

            new MessageView(GameViews.Message.CurrentTurn).WriteLine(_game.GetCurrentTurn().ToString());

            PlayerViewPrototype.Instance.CreateView(_game.GetPlayerType()).Interact(_game);

            new GridView().Show(_game);
        } while (!_game.IsTicTacToe());

        new MessageView(GameViews.Message.Winner).WriteLine(_game.GetCurrentTurn().ToString());
    }
}