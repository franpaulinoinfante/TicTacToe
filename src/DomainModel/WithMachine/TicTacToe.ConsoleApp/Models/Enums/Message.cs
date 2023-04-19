internal enum Message
{
    TicTacToe,
    HorizontalLine,
    VerticalLine,
    EnterThePlayersNumber,
    Row,
    Colunm,
    CurrentTurn,
    EnterCoordinateToPut,
    EnterOriginCoordinateToMove,
    EnterTargetCoordinateToMove,
    Error,
    WinnerMessage,
    Resume,
    Goodbye
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
        "Error!!!",
        "Congratulations player: #player, you WON!!!! :-)",
        "\nDo you want to continue",
        "Thanks, Good Bye!!"
    };

    internal static string GetToString(this Message message)
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

    internal static void WriteLine(this Message message, int value1, int value2)
    {
        ConsoleIO.Instance.WriteLine(_messages[(int)message]
            .Replace("#value1", value1.ToString())
            .Replace("#value2", value2.ToString()));
    }
}