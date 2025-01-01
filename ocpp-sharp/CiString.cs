using System.Diagnostics.CodeAnalysis;

namespace OcppSharp;

/// <summary>
/// Provides an easy to work with type of which Equality and GetHashCode ignore case.
/// However, the original representation is still stored for other use.
/// </summary>
[Newtonsoft.Json.JsonConverter(typeof(CiJsonConverter))]
public readonly struct CiString
{
    public char this[int i]
    {
        get
        {
            return RawValue[i];
        }
    }

    public string RawValue { get; }
    public string Value => RawValue.ToLower();
    public CiString(string rw)
    {
        RawValue = rw;
    }

    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        if (obj == null)
            return false;
        if (obj is string)
            return ((string)obj).Equals(Value, StringComparison.OrdinalIgnoreCase);
        if (obj is CiString cis)
        {
            return cis.Value != null && cis.Value.Equals(Value, StringComparison.OrdinalIgnoreCase);
        }
        return false;
    }

    public override int GetHashCode()
    {
        if (Value == null)
            return 0;
        return Value.GetHashCode();
    }

    public override string ToString()
    {
        return RawValue;
    }

    public static implicit operator string(CiString obj)
    {
        return obj.RawValue;
    }

    public static implicit operator CiString(string str)
    {
        return new CiString(str);
    }

    public static implicit operator string?(CiString? obj)
    {
        return obj?.RawValue;
    }

    public static implicit operator CiString?(string? str)
    {
        if (str == null)
            return null;
        return new CiString(str);
    }

    public static bool operator ==(CiString a, CiString b)
    {
        return a.Equals(b);
    }
    public static bool operator !=(CiString a, CiString b)
    {
        return !a.Equals(b);
    }
}
