using TicTacToe.ConsoleApp.Views.Models;
using TicTacToe.GameViews;
using TicTacToe.Models;

namespace TicTacToe.ConsoleApp.Views;

internal class ResumeView
{
    private Game _game;

    public ResumeView(Game game)
    {
        _game = game;
    }

    internal bool Interact()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(Message.Resume.GetMessage());
        if (yesNoDialog.IsAffirmative())
        {
            new GridView().Clear();
        }

        return yesNoDialog.IsAffirmative();
    }
}