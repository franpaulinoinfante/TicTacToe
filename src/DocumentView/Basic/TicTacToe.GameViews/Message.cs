namespace TicTacToe.GameViews;

public enum Message
{
    Title,
    NumberPlayerMenu,
    SelectNumberPlayer,
    VerticalLine,
    Square,
    CurrentTurn,
    EnterCoordinateToPu,
    EnterOriginCoordinateToMove,
    EnterTargetCoordinateToMove,
    Winner,
    Resume
}

public static class MessageExtension
{
    private static readonly string[] _messages = new string[]
    {
        "--- TicTacToe ---\n",
        "0. Machine vs Machine\n1. Player vs Machine\n2. Player vs Player",
        "Select the number of players: ",
        "---------",
        "[#token]",
        "Current Turn: ",
        "Enter a coordinate to put a token:",
        "Enter the origin coordinate to move:",
        "Enter the target coordinate to move",
        "Congratulations player: X, you WON!!!! :-)",
        "Do you want to continue?"
    };

    public static string GetMessage(this Message message)
    {
        return _messages[(int)message];
    }
}
