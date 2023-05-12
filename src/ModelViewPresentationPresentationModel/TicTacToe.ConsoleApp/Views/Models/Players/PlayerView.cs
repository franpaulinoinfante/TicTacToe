using TicTacToe.Controllers;
using TicTacToe.Types;

namespace TicTacToe.ConsoleApp.Views.Models.Players;

internal abstract class PlayerView
{
    private readonly PlayController _playController;

    public PlayerView(PlayController playController)
    {
        _playController = playController;
    }

    internal void Interact()
    {
        if (_playController.HasToken())
        {
            PutToken();
        }
        else
        {
            MoveToken();
        }
    }

    private void PutToken()
    {
        _playController.PutToken(ReadCoordinateToPut());
    }

    protected abstract Coordinate ReadCoordinateToPut();

    protected Error FindToPutTokenError(Coordinate coordinate)
    {
        return _playController.FindToPutTokenError(coordinate);
    }

    private void MoveToken()
    {
        _playController.MoveToken(ReadCoordinatesToMove());
    }

    protected abstract Coordinate[] ReadCoordinatesToMove();

    protected Error FindOriginToMoveError(Coordinate coordinate)
    {
        return _playController.FindOriginToMoveError(coordinate);
    }

    protected Error FindTargetToMoveError(Coordinate[] coordinates)
    {
        return _playController.FindTargetToMoveError(coordinates);
    }
}
