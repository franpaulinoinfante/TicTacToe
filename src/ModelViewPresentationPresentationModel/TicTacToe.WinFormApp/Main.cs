using TicTacToe.Controllers;
using TicTacToe.GameViews;

namespace TicTacToe.WinFormApp;

public partial class Main : Form, IMainView
{
    public Main()
    {
        InitializeComponent();


        AssociateAndRaiseViewEvents();
    }

    public event EventHandler btnOpenGame;

    private void AssociateAndRaiseViewEvents()
    {
        button1.Click += delegate
        { btnOpenGame?.Invoke(this, EventArgs.Empty); };
    }


    public void Visit(StartController startController)
    {
        MessageBox.Show("Hello");
    }

    public void Visit(PlayController startController)
    {
        throw new NotImplementedException();
    }

    public bool Visit(ResumeController resumeController)
    {
        throw new NotImplementedException();
    }
}
