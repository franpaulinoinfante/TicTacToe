using TicTacToe.Models.Types;

namespace TicTacToe.Models;

public class Game
{
    private readonly Grid _grid;
    private readonly Player[] _players;
    private readonly Turn _turn;

    public Game()
    {
        _grid = new Grid();
        _players = new Player[Turn.MaxPlayer];
        _turn = new Turn(_players);
    }

    private Player CurrentPlayer { get { return _players[_turn.Current]; } }

    public Error CheckErrorToPut(Coordinate coordinate)
    {
        return CurrentPlayer.CheckErrorToPut(coordinate);
    }

    public Error CheckErrorToReadPlayers(int players)
    {
        return PlayerFactory.Instance.CheckErrorToReadPlayers(players);
    }

    public Error CheckErrorToValidCoordinate(Coordinate coordinate)
    {
        return  new Coordinate().CheckErrorToValidCoordinate(coordinate);
    }

    public Error CheckOriginErrorToMove(Coordinate coordinate)
    {
        return CurrentPlayer.CheckOriginErrorToMove(coordinate);
    }

    public Error CheckTargetErrorToMove(Coordinate origin, Coordinate target)
    {
        return CurrentPlayer.CheckTargetErrorToMove(origin, target);
    }

    public void CreatePlayer(int numberPlayers)
    {
        for (int i = 0; i < Turn.MaxPlayer; i++)
        {
            _players[i] = PlayerFactory.Instance.Create(i, numberPlayers, _grid);
        }
    }

    public Token GetCurrent()
    {
        return CurrentPlayer.Token;
    }

    public PlayerType GetPlayerType()
    {
        return CurrentPlayer.PlayerType;
    }

    public Token GetToken(Coordinate coordinate)
    {
        return _grid.GetToken(coordinate);
    }

    public bool HasToken()
    {
        return CurrentPlayer.HasToken();
    }

    public bool IsTicTacToe()
    {
        return _grid.IsTicTacToe(CurrentPlayer.Token);
    }

    public void MoveToken(Coordinate origin, Coordinate target)
    {
        CurrentPlayer.MoveToken(origin, target);
    }

    public void NewGame()
    {
        _grid.NewGame();
    }

    public void Next()
    {
        _turn.Next();
    }

    public void PutToken(Coordinate coordinate)
    {
        CurrentPlayer.PutToken(coordinate);
    }
}
