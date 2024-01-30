using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Controllers;
using TicTacToe.GameViews;

namespace TicTacToe.TicTacToeV2;

public class TicTacToe
{
    private readonly Logic _logic;
    private IGameView _gameView;

    public TicTacToe(IGameView gameView)
    {
        _logic = new Logic();
        _gameView = gameView;
    }

    public void Run()
    {
        Controller controller;
        do
        {
            controller = _logic.Controller;
            controller?.Accept(_gameView);
        } while (controller is not null);
    }
}
