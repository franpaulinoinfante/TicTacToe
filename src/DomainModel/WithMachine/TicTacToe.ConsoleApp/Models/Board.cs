using System.Diagnostics;
using TicTacToe.ConsoleApp.Models.Enums;

namespace TicTacToe.ConsoleApp.Models;

internal class Board
{
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
        Debug.Assert(coordinate != null);

        return IsOccupied(Token.Null, coordinate);
    }

    internal bool IsOccupied(Token token, Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        return GetToken(coordinate) == token;
    }

    private Token GetToken(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        return _tokens[coordinate.Row, coordinate.Column];
    }

    internal void Put(Token token, Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        _tokens[coordinate.Row, coordinate.Column] = token;
    }

    internal void MoveToken(Coordinate origin, Coordinate target)
    {
        Debug.Assert(origin != null && !IsEmpty(origin));
        Debug.Assert(target != null && IsEmpty(target));
        Debug.Assert(!origin.Equals(target));

        Token token = GetToken(origin);
        Put(Token.Null, origin);
        Put(token, target);
    }

    internal bool IsTicTacToe(Token token)
    {
        Debug.Assert(!token.IsNull());

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
                ConsoleIO.Instance.Write(GetToken(new Coordinate(i, j)).GetString());
                Message.VerticalLine.Write();
            }
            ConsoleIO.Instance.WriteLine();
            Message.HorizontalLine.WriteLine();
        }
        ConsoleIO.Instance.WriteLine();
    }
}