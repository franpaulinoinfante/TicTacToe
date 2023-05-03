namespace TicTacToe.Models.Types;

public enum Token
{
    X,
    O,
    Null
}

public static class TokenExtension
{
    public static bool IsNul(this Token token)
    {
        return token == Token.Null;
    }
}
