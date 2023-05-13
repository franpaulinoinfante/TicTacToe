using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Controllers;
using TicTacToe.GameViews;

namespace TicTacToe.WinFormApp;

public partial class Main : Form, IGameView
{
    public Main()
    {
        InitializeComponent();
    }

    public void Visit(StartController startController)
    {
        throw new NotImplementedException();
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
