using System.Reflection;
using OcppSharp.Protocol;

namespace OcppSharp;

public static class Extensions
{
    /// <summary>
    /// Gets an attribute on an enum field value
    /// <example><para>For example:
    /// <code><![CDATA[
    /// string desc = myEnumVariable.GetAttributeOfType<DescriptionAttribute>().Description; 
    /// ]]></code></para>
    /// </example>
    /// </summary>
    /// <typeparam name="T">The type of the attribute you want to retrieve</typeparam>
    /// <param name="enumValue">The enum value</param>
    /// <returns>The attribute of type T that exists on the enum value</returns>
    public static T? GetAttributeOfType<T>(this Enum enumValue) where T : Attribute
    {
        // https://stackoverflow.com/questions/1799370/getting-attributes-of-enums-value
        // https://stackoverflow.com/a/9276348
        Type type = enumValue.GetType();
        MemberInfo[] memInfo = type.GetMember(enumValue.ToString());
        var attributes = memInfo[0].GetCustomAttributes<T>(false);
        return attributes.FirstOrDefault();
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
