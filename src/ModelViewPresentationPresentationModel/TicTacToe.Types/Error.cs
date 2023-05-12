namespace TicTacToe.Types;

public enum Error
{
    InvalidGameMode,
    InvalidCoordinate,
    SquareIsOccupied,
    SquareIsEmpty,
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