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
        return IsOccupied(coordinate, Token.Null);
    }

    internal bool IsOccupied(Coordinate origin, Token token)
    {
        return GetToken(origin) == token;
    }

    private Token GetToken(Coordinate coordinate)
    {
        return _tokens[coordinate.Row, coordinate.Column];
    }

    internal void PutToken(Coordinate coordinate, Token token)
    {
        Debug.Assert(coordinate != null);
        Debug.Assert(_tokens.Length != Board.MaxTokenOnBoard);

        _tokens[coordinate.Row, coordinate.Column] = token;
    }

    internal void MoveToken(Coordinate origin, Coordinate target)
    {
        Token token = GetToken(origin);
        PutToken(origin, Token.Null);
        PutToken(target, token);
    }

    internal bool IsTicTacToe(Token token)
    {
        List<Direction> directions = GetDirections(token);
        if (directions.Count < Coordinate.Dimension - 1)
        {
            return false;
        }

        for (int i = 0; i < directions.Count - 1; i++)
        {
            if (directions[i] != directions[i + 1])
            {
                return false;
            }
        }

        return directions[0] != Direction.Null;
    }

    private List<Direction> GetDirections(Token token)
    {
        List<Direction> directions = new List<Direction>();
        List<Coordinate> coordinates = GetCoordinates(token);
        if (coordinates.Any())
        {
            for (int i = 0; i < coordinates.Count - 1; i++)
            {
                directions.Add(coordinates[i].GetDirection(coordinates[i + 1]));
            }
        }

        return directions;
    }

    private List<Coordinate> GetCoordinates(Token token)
    {
        List<Coordinate> coordinates = new List<Coordinate>();
        for (int i = 0; i < Coordinate.Dimension; i++)
        {
            for (int j = 0; j < Coordinate.Dimension; j++)
            {
                if (GetToken(new Coordinate(i, j)) == token)
                {
                    coordinates.Add(new Coordinate(i, j));
                }
            }
        }

        return coordinates;
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
}