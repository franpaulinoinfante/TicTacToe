using TicTacToe.GameViews;
using TicTacToe.Models;

namespace TicTacToe.WinFormsApp;

public partial class DashBoard : Form, IGameView
{
    private readonly TicTacToe _ticTacToe;
    private readonly Game _game;

    public DashBoard(TicTacToe ticTacToe)
    {
        InitializeComponent();

        _game = ticTacToe.Game;
        _ticTacToe = ticTacToe;
    }

    public bool IsResume()
    {
        throw new NotImplementedException();
    }

    public void Play()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        new GameView(_game).Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _ticTacToe.Run();
    }
}
