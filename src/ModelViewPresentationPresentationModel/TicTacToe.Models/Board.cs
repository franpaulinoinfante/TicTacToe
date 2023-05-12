using TicTacToe.Types;

namespace TicTacToe.Models;

internal class Board
{
    private readonly Token[,] _tokens;

    public Board()
    {
        _tokens = new Token[Coordinate.Dimension, Coordinate.Dimension];
        Reset();
    }

    public void Reset()
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

    internal bool IsOccupied(Coordinate coordinate, Token token)
    {
        return GetToken(coordinate) == token;
    }

    internal Token GetToken(Coordinate coordinate)
    {
        return _tokens[coordinate.Row, coordinate.Column];
    }

    internal void PutToken(Coordinate coordinate, Token token)
    {
        _tokens[coordinate.Row, coordinate.Column] = token;
    }

    internal void MoveToken(Coordinate[] coordinates)
    {
        Coordinate origin = coordinates[0];
        Coordinate target = coordinates[1];

        Token token = _tokens[origin.Row, origin.Column];
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
}