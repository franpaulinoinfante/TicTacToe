using TicTacToe.Models.Types;

namespace TicTacToe.Models;

internal class Grid
{
    private readonly Token[,] _tokens;

    public Grid()
    {
        _tokens = new Token[Coordinate.Dimension, Coordinate.Dimension];
    }

    internal Token GetToken(Coordinate coordinate)
    {
        return _tokens[coordinate.Row, coordinate.Column];
    }

    internal void NewGame()
    {
        for (int i = 0; i < Coordinate.Dimension; i++)
        {
            for (int j = 0; j < Coordinate.Dimension; j++)
            {
                _tokens[i, j] = Token.Null;
            }
        }
    }
}