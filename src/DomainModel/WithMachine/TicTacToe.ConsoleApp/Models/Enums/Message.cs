internal enum Message
{
    TicTacToe,
    HorizontalLine,
    VerticalLine,
    EnterThePlaresNumber,
    Row,
    Colunm,
    CurrentTurn,
    EnterCoordinateToPut,
    EnterOriginCoordinateToMove,
    EnterTargetCoordinateToMove,
    RandomCoordinate,
    Error,
    WinnerMessage,
    Resume,
    Goodbye,
}

internal static class MessageExtension
{
    private static readonly string[] _messages =
    {
        "--- TIC TAC TOE ---\n",
        "-------------",
        " | ",
        "Enter the players' number: ",
        "Row: ",
        "Colunm: ",
        "Current turn: #player",
        "Enter a coordinate to put a token",
        "Enter the origin coordinate to move",
        "Enter the target coordinate to move",
        "Random Coordinate [#title1, #title2]",
        "Error!!!",
        "Congratulations player: #player, you WON!!!! :-)",
        "\nDo you want to continue? (y/n) : ",
        "Thanks, Good Bye!!"
    };

    internal static string GetString(this Message message)
    {
        return _messages[(int)message];
    }

    internal static void Write(this Message message)
    {
        ConsoleIO.Instance.Write(_messages[(int)message]);
    }

    internal static void WriteLine(this Message message)
    {
        ConsoleIO.Instance.WriteLine(_messages[(int)message]);
    }

    internal static void WriteLine(this Message message, string title)
    {
        ConsoleIO.Instance.WriteLine(_messages[(int)message].Replace("#player", title));
    }

    internal static void WriteLine(this Message message, int title1, int title2)
    {
        ConsoleIO.Instance.WriteLine(_messages[(int)message]
            .Replace("#title1", title1.ToString())
            .Replace("#title2", title2.ToString()));
    }
}