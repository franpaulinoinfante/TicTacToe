using TicTacToe.GameViews;
using TicTacToe.Models;
using TicTacToe.Models.Types;

namespace TicTacToe.ConsoleApp.Views.Models.PlayModels;

internal abstract class PlayerView
{
    private Game? _game;

    internal void Interact(Game game)
    {
        _game = game;

        if (game.HasToken())
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
            coordinate = Read(Message.EnterCoordinateToPut, _game);
            error = CheckErrorToPut(coordinate);
        } while (!error.IsNull());

        _game.PutToken(coordinate);
    }

    protected virtual Error CheckErrorToPut(Coordinate coordinate)
    {
        return _game.CheckErrorToPutToken(coordinate);
    }

    protected abstract Coordinate Read(Message message, Game game);

    private void MoveToken()
    {
        Coordinate origin;
        Error error;
        do
        {
            origin = Read(Message.EnterOriginCoordinateToMove, _game);
            error = CheckOriginErrorToMove(origin);
        } while (!error.IsNull());

        Coordinate target;
        do
        {
            target = Read(Message.EnterTargetCoordinateToMove, _game);
            error = CheckTargetErrorToMove(origin, target);
        } while (!error.IsNull());

        _game.MoveToken(origin, target);
    }

    protected virtual Error CheckOriginErrorToMove(Coordinate origin)
    {
        return _game.CheckOriginErrorToMove(origin);
    }

    protected virtual Error CheckTargetErrorToMove(Coordinate origin, Coordinate target)
    {
        return _game.CheckTargetErrorToMove(origin, target);
    }
}
