internal enum Message
{
    TicTacToe,
    HorizontalLine,
    VerticalLine,
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
    private static string[] _messages = 
    {
        "--- TIC TAC TOE ---\n",
        "-------------",
        " | ",
        "Row: ",
        "Colunm: ",
        "Current turn: #player",
        "Enter a coordinate to put a token",
        "Enter the origin coordinate to move",
        "Enter the target coordinate to move",
        "Error!!!",
        "Congratulations player: #player, you WON!!!! :-)",
        "\nDo you want to continue? (y/n) : ",
        "Thanks, Good Bye!!"
    };

    internal static void Write(this Message message)
    {
        ConsoleIO.Instance.Write(_messages[(int)message]);
    }


    internal static void WriteLine(this Message message)
    {
        ConsoleIO.Instance.WriteLine(_messages[(int)message]);
    }

    internal static void WriteLine(this Message message, string player)
    {
        ConsoleIO.Instance.WriteLine(_messages[(int)message].Replace("#player", player));
    }

    internal static String GetString(this Message message)
    {
        return _messages[(int)message];
    }
}
