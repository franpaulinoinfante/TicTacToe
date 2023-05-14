using TicTacToe.ConsoleApp.Views.Models;
using TicTacToe.Controllers;
using TicTacToe.GameViews;

namespace TicTacToe.ConsoleApp.Views;

internal class ResumeView
{
    internal bool Interact(ResumeController resumeController)
    {
        YesNoDialog yesNoDialog = new();
        yesNoDialog.Read(Message.Resume.GetMessage());

        if (yesNoDialog.IsAffirmative())
        {
            resumeController.Reset();
            new BoardView().Clear();
        }
        else
        {
            resumeController.NextState();
        }

        return yesNoDialog.IsAffirmative();
    }
}