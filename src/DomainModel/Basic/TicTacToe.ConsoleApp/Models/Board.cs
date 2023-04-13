using System.Diagnostics;

internal class Board
{
    private Token[,] _tokens;

    public Board()
    {
        _tokens = new Token[Coordinate.Dimension, Coordinate.Dimension];
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

    private Token GetToken(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        return _tokens[coordinate.Row, coordinate.Colunm];
    }

    internal void PutToken(Coordinate coordinate, Token token)
    {
        Debug.Assert(coordinate != null);

        _tokens[coordinate.Row, coordinate.Colunm] = token;
    }

    internal void Move(Coordinate origin, Coordinate target)
    {
        Debug.Assert(origin != null && !IsEmpty(origin));
        Debug.Assert(target != null && IsEmpty(target));
        Debug.Assert(!origin.Equals(target));

        Token token = GetToken(origin);
        PutToken(origin, Token.Null);
        PutToken(target, token);
    }

    internal bool IsEmpty(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        return IsOccupied(coordinate, Token.Null);
    }

    internal bool IsOccupied(Coordinate coordinate, Token token)
    {
        Debug.Assert(coordinate != null);

        return GetToken(coordinate) == token;
    }

    internal bool IsTicTacToe(Token token)
    {
        Debug.Assert(!token.IsNull());

        List<Direction> directions = GetDirections(token);
        if (directions.Count < Coordinate.Dimension - 1)
        {
            return false;
        }
        else
        {
            for (int i = 0; i < directions.Count - 1; i++)
            {
                if (directions[i] != directions[i + 1])
                {
                    return false;
                }
            }
        }

        return directions[0] != Direction.Null;
    }

    private List<Direction> GetDirections(Token token)
    {
        Debug.Assert(!token.IsNull());

        List<Coordinate> coordinates = GetCoordinates(token);
        List<Direction> directions = new List<Direction>();
        if (coordinates.Count > 0)
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
        Debug.Assert(!token.IsNull());

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
                ConsoleIO.Instance.Write(_tokens[i, j].GetToken());
                Message.VerticalLine.Write();
            }
            ConsoleIO.Instance.WriteLine();
        }
        Message.HorizontalLine.WriteLine();
        ConsoleIO.Instance.WriteLine();
    }
}