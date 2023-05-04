using TicTacToe.Models.Types;

namespace TicTacToe.ConsoleApp.Views.Models.PlayModels;

internal class PlayerViewPrototype
{
    private static PlayerViewPrototype? _instance;

    private readonly Dictionary<PlayerType, PlayerView> _playersViewAssoc;

    private PlayerViewPrototype()
    {
        _playersViewAssoc = new Dictionary<PlayerType, PlayerView>
        {
            { PlayerType.MachinePlayer, new MachinePlayerView() },
            { PlayerType.UserPlayer, new UserPlayerView() }
        };
    }

    public static PlayerViewPrototype Instance
    {
        get
        {
            return _instance ?? (_instance = new PlayerViewPrototype());
        }
    }

    internal PlayerView CreateView(PlayerType playerType)
    {
        return _playersViewAssoc[playerType];
    }
}