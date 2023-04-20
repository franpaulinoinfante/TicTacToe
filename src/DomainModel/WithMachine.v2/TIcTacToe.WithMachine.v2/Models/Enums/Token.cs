internal enum Token
{
    X,
    O,
    Null
}

internal static class TokenExtension
{
    internal static string GetToString(this Token token)
    {
        if (token.IsNull())
        {
            return " ";
        }

        return token.ToString();
    }

    internal static bool IsNull(this Token token)
    {
        return Token.Null == token;
    }
}
