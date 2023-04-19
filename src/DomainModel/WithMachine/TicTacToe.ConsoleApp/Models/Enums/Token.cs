namespace TicTacToe.ConsoleApp.Models.Enums;

internal enum Token
{
    X,
    O,
    Null
}

internal static class TokenExtension
{
    internal static string GetString(this Token token)
    {
        return token.IsNull() ? " " : token.ToString();
    }

    internal static bool IsNull(this Token token)
    {
        return token == Token.Null;
    }
}