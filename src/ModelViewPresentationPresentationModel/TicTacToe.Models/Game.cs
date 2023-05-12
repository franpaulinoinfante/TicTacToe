using TicTacToe.Types;

namespace TicTacToe.Models;

public class Game
{
    private readonly Board _board;
    private readonly Player[] _players;
    private readonly Turn _turn;

    public Game()
    {
        _board = new Board();
        _players = new Player[Turn.NumberOfPlayers];
        _turn = new Turn(_players);
    }

    public void Reset()
    {
        _board.Reset();

        foreach (Player player in _players)
        {
            player.Reset();
        }
    }

    public Token GetToken(Coordinate coordinate)
    {
        return _board.GetToken(coordinate);
    }

    public void SetGameModePlayers(GameMode gameModePlayers)
    {
        _turn.SetGameModePlayers(gameModePlayers, _board);
    }

    public PlayerType GetPlayerType()
    {
        return _players[_turn.Current].PlayerType;
    }

    public void NextTurn()
    {
        _turn.Next();
    }

    public bool HasToken()
    {
        return _players[_turn.Current].HasToken();
    }

    public void PutToken(Coordinate coordinate)
    {
        _players[_turn.Current].PutToken(coordinate);
    }

    public Error FindToPutTokenError(Coordinate coordinate)
    {
        return _players[_turn.Current].FindToPutTokenError(coordinate);
    }

    public void MoveToken(Coordinate[] coordinates)
    {
        _players[_turn.Current].MoveToken(coordinates);
    }

    public Error FindOriginToMoveError(Coordinate coordinate)
    {
        return _players[_turn.Current].FindOriginToMoveError(coordinate);
    }

    public Error FindTargetToMoveError(Coordinate[] coordinates)
    {
        return _players[_turn.Current].FindTargetToMoveError(coordinates);
    }

    public bool IsTicTacToe()
    {
        return _board.IsTicTacToe(_players[_turn.Current].Token);
    }

    public Token GetCurrentTokenFromTurn()
    {
        return _players[_turn.Current].Token;
    }
}
