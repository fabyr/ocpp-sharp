namespace OcppSharp;

public class Logger
{
    public static Logger Default => new(Console.Out, Console.Error);

    private readonly TextWriter @out, err;

    public Logger(TextWriter @out, TextWriter err)
    {
        this.@out = @out;
        this.err = err;
    }

    public bool EnableLogging { get; set; } = true;

    private static string GetCurrentDateFormatted(bool dateFormat)
    {
        if (dateFormat)
            return $"{DateTime.Now:HH:mm:ss}\t";
        return string.Empty;
    }

    protected virtual void WriteTo(TextWriter writer, params string[] text)
    {
        if (EnableLogging)
            foreach (string item in text)
                writer.Write(item);
    }

    protected virtual string[] GetFormattedLine(string text, bool dateFormat = true)
    {
        return [GetCurrentDateFormatted(dateFormat), text, Environment.NewLine];
    }

    public virtual void Write(params string[] text) => WriteTo(@out, text);
    public virtual void WriteLine(string text, bool dateFormat = true) => Write(GetFormattedLine(text, dateFormat));

    public virtual void WriteErr(params string[] text) => WriteTo(err, text);
    public virtual void WriteLineErr(string text, bool dateFormat = true) => WriteErr(GetFormattedLine(text, dateFormat));

    // Might add special formatting in future
    public virtual void WriteVerbose(params string[] text) => Write(text);
    public virtual void WriteVerboseLine(string text, bool dateFormat = true) => WriteVerbose(GetFormattedLine(text, dateFormat));

    public virtual void WriteWarn(params string[] text) => Write(text);
    public virtual void WriteLineWarn(string text, bool dateFormat = true) => WriteWarn(GetFormattedLine(text, dateFormat));
}
