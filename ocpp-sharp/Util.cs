using System.Text.RegularExpressions;
using OcppSharp.Protocol;

namespace OcppSharp;

public static partial class Util
{
    [GeneratedRegex(@"^.+?.\/(.+?)\/?$")]
    private static partial Regex IDRegex();

    [GeneratedRegex(@"^(\/.+\/).+$")]
    private static partial Regex SubPathRegex();

    public static string IdFromRequestLine(string? requestLine)
    {
        // TODO: Find better solution?
        return IDRegex().Match(requestLine ?? string.Empty).Groups[1].Value.Split('/').Last();
    }

    public static string SubPathFromRequestLine(string? requestLine)
    {
        return SubPathRegex().Match(requestLine ?? string.Empty).Groups[1].Value;
    }

    public static string GetWebSocketSubProtocol(this ProtocolVersion version)
    {
        return version.GetAttributeOfType<StringValueAttribute>()?.Text
                ?? throw new ArgumentException("OCPP protocol version does not define a StringValueAttribute.", nameof(version));
    }
}
