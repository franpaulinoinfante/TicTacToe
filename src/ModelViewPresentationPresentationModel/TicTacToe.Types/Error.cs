namespace TicTacToe.Types;

public enum Error
{
    InvalidGameMode,
    InvalidCoordinate,
    SquareIsOccupied,
    NotOwnerToken,
    OriginAndTargetCoordinateCannotBeSame,
    Null
}

public static class ErrorExtension
{
    public static bool IsNull(this Error error)
    {
        return error.Equals(Error.Null);
    }
}