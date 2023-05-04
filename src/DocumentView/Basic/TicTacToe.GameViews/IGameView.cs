namespace TicTacToe.GameViews;

public interface IGameView
{
    public void Start();
    public void Play();
    bool IsResume();
}
