using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace OcppSharp;

/// <summary>
/// Provides an easy to work with type of which Equality and GetHashCode ignore case.
/// However, the original representation is still stored for other use. (<see cref="RawValue"/>)
/// </summary>
[JsonConverter(typeof(CiJsonConverter))]
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
        if (obj is string stringValue)
            return stringValue.Equals(Value, StringComparison.OrdinalIgnoreCase);
        if (obj is CiString ciStringValue)
        {
            return ciStringValue.Value.Equals(Value);
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Value?.GetHashCode() ?? 0;
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
