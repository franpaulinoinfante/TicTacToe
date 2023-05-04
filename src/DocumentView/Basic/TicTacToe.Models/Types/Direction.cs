using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models.Types;
internal enum Direction
{
    Horizontal,
    Vertical,
    MainDiagonal,
    InverseDiagonal,
    Null
}

internal static class DirectionExtension
{
    internal static bool IsNull(this Direction direction)
    {
        return direction == Direction.Null;
    }
}
