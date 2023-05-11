using TicTacToe.Models;
using TicTacToe.Types;

namespace TicTacToe.Controllers;

public class Logic
{
    private readonly Dictionary<StateCode, Controller> _controllerPairs;

    private readonly Game _game;
    private readonly State _state;

    public Logic()
    {
        _game = new Game();
        _state = new State();

        _controllerPairs = new Dictionary<StateCode, Controller>()
        {
            { StateCode.Initial , new StartController(_game, _state) },
            { StateCode.InGame , new PlayController(_game, _state) },
            { StateCode.OutOfGame , new ResumeController(_game, _state) },
            { StateCode.Exit , null }
        };
    }

    public Controller Controller => _controllerPairs[_state.StateCode];
}
