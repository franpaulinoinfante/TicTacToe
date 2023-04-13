using System.Diagnostics;

public class YesNoDialog
{
    private const char AFFIRMATIVE = 'y';
    private const char NEGATIVE = 'n';
    private static readonly string SUFFIX = $"? ({AFFIRMATIVE}/{NEGATIVE})";
    private static readonly string MESSAGE = $"The value must be: ({AFFIRMATIVE} or {NEGATIVE})";

    private string? _answer;

    public void Read(string? message)
    {
        Debug.Assert(message != null);

        ConsoleIO consoleIO = ConsoleIO.Instance;
        bool ok;
        do
        {
            consoleIO.Write(message);
            _answer = consoleIO.ReadString(SUFFIX);

            ok = IsAffirmative() || IsNegative();
            if (!ok)
            {
                consoleIO.WriteLine(MESSAGE);
            }
        } while (!ok);
    }

    public bool IsAffirmative() => GetAnswer() == AFFIRMATIVE;

    private char GetAnswer()
    {
        return char.ToLower(_answer.ToCharArray()[0]);
    }

    public bool IsNegative() => GetAnswer() == NEGATIVE;
}
