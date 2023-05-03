using TicTacToe.Models.Types;

namespace TicTacToe.Models;
internal class UserPlayer : Player
{
    public UserPlayer(Grid grid, Token token, PlayerType userPlayer) : base(grid, token, userPlayer)
    {
    }
}