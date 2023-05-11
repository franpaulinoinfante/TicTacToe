using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Controllers;
using TicTacToe.Types;

namespace TicTacToe.ConsoleApp.Views.Models.Players;

internal class PlayerViewPrototype
{
    private PlayerViewPrototype() { }

    internal static PlayerViewPrototype Instance
    {
        get
        {
            return Instance ?? new PlayerViewPrototype();
        }
    }

    internal PlayerView Create(PlayController playController)
    {
        return playController.GetPlayerType() == PlayerType.UserPlayer 
            ? new UserPlayerView(playController) 
            : new MachinePlayerView(playController);
    }
}
