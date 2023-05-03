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

    public Error CheckErrorToReadPlayers(int players)
    {
        return PlayerFactory.Instance.CheckErrorToReadPlayers(players);
    }

    public void CreatePlayer(int numberPlayers)
    {
        for (int i = 0; i < Turn.MaxPlayer; i++)
        {
            _players[i] = PlayerFactory.Instance.Create(i, numberPlayers, _grid);
        }
    }

    public Token GetToken(Coordinate coordinate)
    {
        return _grid.GetToken(coordinate);
    }

    public void NewGame()
    {
        _grid.NewGame();
    }
}
