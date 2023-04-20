internal enum Message
{
    TicTacToe,
    EnterNumberOfPlayers,
    HorizontalLine,
    VerticalLine,
    CurrentTurn,
    EnterCoordinateToPut,
    EnterOriginCoordinateToMove,
    EnterTargetCoordinateToMove,
    Row,
    Colunm,
    Error,
    WinnerMessage,
    Resume,
    GoodByeMessage
}

internal static class MessageExtension
{
    static string[] _messages = new string[]
    {
        "---- TIC TAC TOE ----\n",
        "Enter the number of players: ",
        "-------------",
        " | ",
        "Current turn: #player",
        "Enter a coordinate to put a token",
        "Enter the origin coordinate to move",
        "Enter the target coordinate to move",
        "Row: ",
        "Colunm: ",
        "Error!!!!!!",
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

    internal static void WriteLine(this Message message, string player)
    {
        ConsoleIO.Instance.WriteLine(_messages[(int)message].Replace("#player", player));
    }
}