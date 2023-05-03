﻿namespace TicTacToe.Models.Types;

public enum Error
{
    InvalidPlayerSelect,
    Null
}

public static class ErrorExtension
{
    public static bool IsNull(this Error error)
    {
        return error == Error.Null;
    }
}