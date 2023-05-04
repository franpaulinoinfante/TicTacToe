using TicTacToe.Models.Types;

namespace TicTacToe.Models;

internal class Grid
{
    private readonly Token[,] _tokens;

    public Grid()
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

    internal Token GetToken(Coordinate coordinate)
    {
        return _tokens[coordinate.Row, coordinate.Column];
    }

    internal bool IsEmpty(Coordinate coordinate)
    {
        return IsOccupied(coordinate, Token.Null);
    }

    internal bool IsOccupied(Coordinate coordinate, Token token)
    {
        return GetToken(coordinate) == token;
    }

    internal void MoveToken(Coordinate origin, Coordinate target)
    {
        Token token = GetToken(origin);
        PutToken(origin, Token.Null);
        PutToken(target,token);
    }

    internal void PutToken(Coordinate coordinate, Token token)
    {
        _tokens[coordinate.Row, coordinate.Column] = token;
    }

    internal bool IsTicTacToe(Token token)
    {
        List<Direction> directions = GetDirection(token);
        if (directions.Count < Coordinate.Dimension - 1)
        {
            return false;
        }

        for (int i = 0; i < directions.Count - 1; i++)
        {
            if (directions[i] != directions[i+1])
            {
                return false;
            }
        }

        return !directions[index: 0].IsNull();
    }

    private List<Direction> GetDirection(Token token)
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
                Coordinate coordinate = new Coordinate(i, j);
                if (GetToken(coordinate) == token)
                {
                    coordinates.Add(coordinate);
                }
            }
        }

        
        return coordinates;
    }
}