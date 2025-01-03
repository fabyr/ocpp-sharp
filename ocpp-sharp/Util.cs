using System.Text.RegularExpressions;
using OcppSharp.Protocol;

namespace OcppSharp;

public static partial class Util
{
    [GeneratedRegex(@"^.+?.\/(.+?)\/?$")]
    private static partial Regex IDRegex();

    [GeneratedRegex(@"^(\/.+\/).+$")]
    private static partial Regex SubPathRegex();

    /// <summary>
    /// Extracts the charge point connection id from its websocket url.
    /// <example>
    /// For example:
    /// <code>
    /// string path = "/ocpp16/example_id_1234";
    /// Util.IdFromRequestLine(path);
    /// </code>
    /// will return <c>example_id_1234</c>
    /// </example>
    /// </summary>
    /// <param name="requestLine">The absolute path of the uri the chargepoint used to connect.</param>
    /// <returns>The extracted id as a string.</returns>
    public static string IdFromRequestLine(string? requestLine)
    {
        // TODO: Find better solution?
        return IDRegex().Match(requestLine ?? string.Empty).Groups[1].Value.Split('/').Last();
    }

    /// <summary>
    /// Extracts the part in front of the charge point id from the websocket url.
    /// <example>
    /// For example:
    /// <code>
    /// string path = "/ocpp16/example_id_1234";
    /// Util.SubPathFromRequestLine(path);
    /// </code>
    /// will return <c>/ocpp16/</c>
    /// </example>
    /// </summary>
    /// <param name="requestLine">The absolute path of the uri the chargepoint used to connect.</param>
    /// <returns>The extracted path as a string. The path will start and end with a <c>/</c> character.</returns>
    public static string SubPathFromRequestLine(string? requestLine)
    {
        return SubPathRegex().Match(requestLine ?? string.Empty).Groups[1].Value;
    }

    /// <summary>
    /// Returns the websocket sub-protocol string for an OCPP protocol version value.
    /// </summary>
    /// <param name="version">The protocol version enum value.</param>
    /// <returns>The websocket sub-protocol value as a string.</returns>
    /// <exception cref="ArgumentException">If the supplied protocol version does not define a websocket sub-protocol string.</exception>
    public static string GetWebSocketSubProtocol(this ProtocolVersion version)
    {
        return version.GetAttributeOfType<StringValueAttribute>()?.Text
                ?? throw new ArgumentException("OCPP protocol version does not define a StringValueAttribute.", nameof(version));
    }
}
