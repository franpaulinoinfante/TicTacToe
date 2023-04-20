using System.Diagnostics;

internal class PlayerConfiguration
{
    private const int Zero = 0;

    internal void Configure(Player[] players, Board board)
    {
        Debug.Assert((players != null) && (board != null));

        int numberOfPlayers = Get();
        for (int i = 0; i < Turn.MaxPlayer; i++)
        {
            if (i < numberOfPlayers)
            {
                players[i] = new UserPlayer(Enum.GetValues<Token>()[i], board);
            }
            else
            {
                players[i] = new MachinePlayer(Enum.GetValues<Token>()[i], board);
            }
        }
    }

    private int Get()
    {
        int numberOfPlayers;
        Error error;
        do
        {
            numberOfPlayers = ConsoleIO.Instance.ReadInt(Message.EnterNumberOfPlayers.GetToString());
            error = CheckErrorToSet(numberOfPlayers);
        } while (!error.IsNull());

        return numberOfPlayers;
    }

    private Error CheckErrorToSet(int numberOfPlayers)
    {
        if ((Zero > numberOfPlayers) || (numberOfPlayers > Turn.MaxPlayer))
        {
            return Error.NumberOfPlayerOutOfRange;
        }

        return Error.Null;
    }
}
