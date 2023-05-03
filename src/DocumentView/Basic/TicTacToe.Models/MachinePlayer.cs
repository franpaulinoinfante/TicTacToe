using TicTacToe.Models.Types;

namespace TicTacToe.Models;
internal class MachinePlayer : Player
{
    public MachinePlayer(Grid grid, Token token, PlayerType machinePlayer) : base(grid, token, machinePlayer)
    {
    }
}