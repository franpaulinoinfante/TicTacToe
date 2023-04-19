﻿using TicTacToe.ConsoleApp.Models.Enums;

namespace TicTacToe.ConsoleApp.Models.Players;

internal class MachinePlayer : Player
{
    public MachinePlayer(Token token, Board board) : base(token, board)
    {
    }

    protected override Coordinate GetCoordinate(Message message)
    {
        Coordinate coordinate = new Coordinate();
        coordinate.ReadRandom();
        return coordinate;
    }
}
