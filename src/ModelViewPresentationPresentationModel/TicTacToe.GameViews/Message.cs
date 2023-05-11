namespace TicTacToe.GameViews;

public enum Message
{
    Title,
    GameModePlayersDetails,
    SelectGameModePlayers,
    ErrorTitle,
    HorizontalLine,
    LeftSideOfSquare,
    RightSideOfSquare,
    CurrentTurn,
    EnterCoordinateToPut,
    EnterOriginCoordinateToMove,
    EnterTargetCoordinateToMove,
    WinnerMessage,
    Resume
}

public static class MessageExtension
{
    private static readonly string[] _messages = new string[]
    {
        "--- TicTacToe ---",
        "0. Machine vs Machine\r\n1. Player vs Machine\r\n2. Player vs Player",
        "Select game mode of players: ",
        "Error!!",
        "---------",
        "[",
        "]",
        "Current turn: ",
        "Enter a coordinate to put a token:",
        "Enter the origin coordinate to move:",
        "Enter the target coordinate to move:",
        "Congratulations player: #player, you WON!!!! :-)",
        "Do you want to continue? "
    };

    public static string GetMessage(this Message message)
    {
        return _messages[(int)message];
    }
}

