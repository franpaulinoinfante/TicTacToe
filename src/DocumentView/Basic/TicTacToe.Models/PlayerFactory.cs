using TicTacToe.Models.Types;

namespace TicTacToe.Models;

internal class PlayerFactory
{
    private static PlayerFactory? _instance;

    private PlayerFactory() { }

    public static PlayerFactory Instance
    {
        get
        {
            return _instance ?? (_instance = new PlayerFactory());
        }
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