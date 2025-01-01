namespace OcppSharp.Protocol.Version201.Standard;

public static class Util
{
    private static readonly Dictionary<string, UnitOfMeasure> dict;

    static Util()
    {
        dict = [];
        UnitOfMeasure[] values = Enum.GetValues<UnitOfMeasure>();
        foreach (UnitOfMeasure v in values)
        {
            var attr = v.GetAttributeOfType<StringValueAttribute>()!;
            dict.Add(attr.Text, v);
        }
    }

    public static string GetUnitString(this UnitOfMeasure v)
    {
        return v.GetAttributeOfType<StringValueAttribute>()!.Text;
    }

    /// <summary>
    /// Converts a String Unit to its corresponding <see cref="UnitOfMeasure"/> Value.<br/>
    /// Returns null if the string does not match any known unit. 
    /// </summary>
    public static UnitOfMeasure? GetUnitFromString(string? s)
    {
        if (s == null)
            return null;
        if (dict.TryGetValue(s, out UnitOfMeasure result))
            return result;
        return null;
    }
}
