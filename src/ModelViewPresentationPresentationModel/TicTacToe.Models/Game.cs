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

    public void SetGameModePlayers(int gameModePlayers)
    {
        _turn.SetGameModePlayers(gameModePlayers, _board);
    }
}
