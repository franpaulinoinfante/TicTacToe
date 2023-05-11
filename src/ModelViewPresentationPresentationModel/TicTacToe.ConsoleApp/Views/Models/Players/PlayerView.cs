using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Controllers;
using TicTacToe.GameViews;
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
        Coordinate coordinate;
        Error error;
        do
        {
            coordinate = GetCoordinate(Message.EnterCoordinateToPut);
            error = FindToPutTokenError(coordinate);
            new ErrorView().Show(error);
        } while (!error.IsNull());

        _playController.PutToken(coordinate);
    }

    protected abstract Coordinate GetCoordinate(Message enterCoordinateToPut);

    protected virtual Error FindToPutTokenError(Coordinate coordinate)
    {
        return _playController.FindToPutTokenError(coordinate);
    }

    private void MoveToken()
    {
        _playController.MoveToken(GetCoordinatesToMove());
    }

    protected abstract Coordinate[] GetCoordinatesToMove();

    protected Error FindOriginToMoveError(Coordinate coordinate)
    {
        return _playController.FindOrigiToMoveError(coordinate);
    }

    protected Error FindTargetToMoveError(Coordinate[] coordinates)
    {
        return _playController.FindTargetToMoveError(coordinates);
    }
}
