using System.Diagnostics;
using TicTacToe.ConsoleApp.Models.Enums;

namespace TicTacToe.ConsoleApp.Models.Players;

internal class PlayerConfiguration
{
    internal Player[] Configure(Board board)
    {
        Debug.Assert(board != null);

        int playersNumber = Read();

        Player[] players = new Player[Turn.PlayersNumber];
        for (int i = 0; i < Turn.PlayersNumber; i++)
        {
            if (i < playersNumber)
            {
                players[i] = new UserPlayer(Enum.GetValues<Token>()[i], board);
            }
            else
            {
                players[i] = new MachinePlayer(Enum.GetValues<Token>()[i], board);
            }
        }

        return players;
    }

    private int Read()
    {
        int players;
        Error error;
        do
        {
            players = ConsoleIO.Instance.ReadInt(Message.EnterThePlaresNumber.GetString());
            error = CheckErrorToEnterPlayersNumber(players);
        } while (!error.IsNull());

        return players;
    }

    private Error CheckErrorToEnterPlayersNumber(int players)
    {
        return (players < 0) || (players > Turn.PlayersNumber) ? Error.ErrorToEnterPlayersNumber : Error.Null;
    }
}