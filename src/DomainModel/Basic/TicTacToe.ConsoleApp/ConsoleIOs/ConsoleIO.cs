public class ConsoleIO
{
    private static ConsoleIO? _instance;

    private ConsoleIO() { }

    public static ConsoleIO Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ConsoleIO();
            }

            return _instance;
        }
    }

    public string ReadString()
    {
        return ReadString(string.Empty);
    }

    public string ReadString(string? title)
    {
        string input = string.Empty;
        bool ok = false;
        do
        {
            Write(title);
            try
            {
                input = Console.ReadLine();
                ok = true;
            }
            catch (Exception)
            {
                WriteError("de cadena de caracteres");
            }
        } while (!ok);

        return input;
    }

    public char ReadChar(string title)
    {
        char charValue = ' ';
        bool ok = false;
        do
        {
            string input = ReadString(title);
            if (input.Length == 1)
            {
                charValue = input.ToCharArray()[0];
                ok = true;
            }
            else
            {
                WriteError("de un caracter");
            }
        } while (!ok);

        return charValue;
    }

    public int ReadInt(string? title)
    {
        int number = 0;
        bool ok = false;
        do
        {
            try
            {
                number = int.Parse(ReadString(title));
                ok = true;
            }
            catch
            {
                WriteError("entero");
            }
        } while (!ok);

        return number;
    }

    public void Write(string? outString)
    {
        Console.Write(outString);
    }

    public void Write(char outChar)
    {
        Write(outChar.ToString());
    }

    public void Write(int outInt)
    {
        Write(outInt.ToString());
    }

    public void WriteLine()
    {
        Console.WriteLine();
    }

    public void WriteLine(string? outString)
    {
        Console.WriteLine(outString);
    }

    public void WriteLine(int outInt)
    {
        Console.WriteLine(outInt);
    }

    private void WriteError(string format)
    {
        WriteLine($"ERROR DE FORMATO.\tIntroduzca un valor con formato: {format}");
    }
}