using System.Reflection;

namespace OcppSharp.Protocol;

// https://stackoverflow.com/questions/1799370/getting-attributes-of-enums-value
// https://stackoverflow.com/a/9276348
public static class EnumHelper
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
        Type type = enumValue.GetType();
        MemberInfo[] memInfo = type.GetMember(enumValue.ToString());
        var attributes = memInfo[0].GetCustomAttributes<T>(false);
        return attributes.FirstOrDefault();
    }
}
