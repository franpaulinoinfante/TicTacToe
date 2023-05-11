namespace TicTacToe.Types;

public enum Token
{
    X,
    O,
    Null
}

public static class TokenExtension
{
    public static bool IsNull(this Token token)
    {
        return token.Equals(Token.Null);
    }
}

