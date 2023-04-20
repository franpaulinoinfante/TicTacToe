internal enum Error
{
    NumberOfPlayerOutOfRange,
    CoordinateIsOutOfRange,
    SquareIsOccupied,
    SquareIsEmpty,
    NotOwnerToken,
    OriginAndTargetSquareCannotBeSame,
    Null
}

internal static class ErrorExtension
{
    private static readonly string[] _errors = new string[]
    {
        "Number of players is out of range",
        "The square is out of range",
        "The square is occupied",
        "The square is empty",
        "The token is not of current player",
        "The squares of origin and destination cannot be the same."
    };

    internal static bool IsNull(this Error error)
    {
        return Error.Null == error;
    }

    internal static void WriteLine(this Error error)
    {
        if (!error.IsNull())
        {
            ConsoleIO.Instance.WriteLine();
            Message.HorizontalLine.WriteLine();
            Message.Error.WriteLine();
            ConsoleIO.Instance.WriteLine(_errors[(int)error]);
            Message.HorizontalLine.WriteLine();
            ConsoleIO.Instance.WriteLine();
        }
    }
}
