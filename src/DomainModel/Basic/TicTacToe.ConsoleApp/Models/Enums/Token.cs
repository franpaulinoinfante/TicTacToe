internal enum Token
{
    X,
    O,
    Null
}

internal static class TokenExtension
{
    internal static string GetToken(this Token token)
    {
        return token.IsNull() ? " " : token.ToString();
    }

    internal static bool IsNull(this Token token)
    {
        return token == Token.Null;
    }
}
