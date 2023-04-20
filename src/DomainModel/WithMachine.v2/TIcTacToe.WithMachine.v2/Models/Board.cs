using System.Diagnostics;

internal class Board
{
    private const int MaxTokenOnBoard = 6;

    private readonly Token[,] _tokens;

    public Board()
    {
        _tokens = new Token[Coordinate.Dimension, Coordinate.Dimension];
    }

    internal void Reset()
    {
        for (int i = 0; i < Coordinate.Dimension; i++)
        {
            for (int j = 0; j < Coordinate.Dimension; j++)
            {
                _tokens[i, j] = Token.Null;
            }
        }
    }

    internal bool IsEmpty(Coordinate coordinate)
    {
        throw new NotImplementedException();
    }

    internal void PutToken(Coordinate coordinate, Token token)
    {
        Debug.Assert(coordinate != null);
        Debug.Assert(_tokens.Length != Board.MaxTokenOnBoard);

        _tokens[coordinate.Row, coordinate.Colunm] = token;
    }

    internal bool IsTicTacToe(Token token)
    {
        throw new NotImplementedException();
    }

    internal void Write()
    {
        Message.HorizontalLine.WriteLine();
        for (int i = 0; i < Coordinate.Dimension; i++)
        {
            Message.VerticalLine.Write();
            for (int j = 0; j < Coordinate.Dimension; j++)
            {
                ConsoleIO.Instance.Write(GetToken(new Coordinate(i, j)).GetToString());
                Message.VerticalLine.Write();
            }
            ConsoleIO.Instance.WriteLine();
            Message.HorizontalLine.WriteLine();
        }
        ConsoleIO.Instance.WriteLine();
    }

    private Token GetToken(Coordinate coordinate)
    {
        return _tokens[coordinate.Row, coordinate.Colunm];
    }
}