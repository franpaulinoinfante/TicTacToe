using TicTacToe.Models.Types;

namespace TicTacToe.Models;

internal class PlayerFactory
{
    private const int MinPlayers = 0;
    private static PlayerFactory? _instance;

    private PlayerFactory() { }

    public static PlayerFactory Instance
    {
        get
        {
            return _instance ?? (_instance = new PlayerFactory());
        }
    }

    internal Error CheckErrorToReadPlayers(int players)
    {
        if ((PlayerFactory.MinPlayers > players) || (players > Turn.MaxPlayer))
        {
            return Error.InvalidPlayerSelect;
        }

        return Error.Null;
    }

    internal Player Create(int position, int numberPlayers, Grid grid)
    {
        Token[] tokens = Enum.GetValues<Token>();

        if (position < numberPlayers)
        {
            return new UserPlayer(grid, tokens[position], PlayerType.UserPlayer);
        }
        else
        {
            return new MachinePlayer(grid, tokens[position], PlayerType.MachinePlayer);
        }
    }
}