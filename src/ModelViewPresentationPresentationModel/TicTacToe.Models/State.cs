using TicTacToe.Types;

namespace TicTacToe.Models;

public class State
{
    public State()
    {
        Reset();
    }

    public StateCode StateCode { get; private set; }

    public void Reset()
    {
        StateCode = StateCode.Initial;
    }

    public void Next()
    {
        StateCode++;
    }
}
