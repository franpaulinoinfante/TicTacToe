using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.GameViews;
using TicTacToe.Models;
using TicTacToe.Models.Types;

namespace TicTacToe.ConsoleApp.Views.Models;

internal class PlayerCreateView
{
    internal int Read(Game game)
    {
        int players;
        Error error;
        do
        {
            players = ConsoleIO.Instance.ReadInt(Message.SelectNumberPlayer.GetMessage());
            error = game.CheckErrorToReadPlayers(players);
            new ErrorView(error).WriteLine();
        } while (!error.IsNull());

        return players;
    }
}
