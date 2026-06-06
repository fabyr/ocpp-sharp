using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace OcppSharp;

/// <summary>
/// Provides an easy to work with type of which Equality and GetHashCode ignore case.
/// ("case insensitive string")
/// However, the original representation is still stored for other use. (<see cref="RawValue"/>)
/// </summary>
[JsonConverter(typeof(CiJsonConverter))]
public readonly struct CiString : IEquatable<CiString>, IEquatable<CiString?>, IEquatable<string>
{
    public static StringComparison StringComparisonMode { get; } = StringComparison.InvariantCultureIgnoreCase;

    public string RawValue { get; }

    public string Value => RawValue.ToLowerInvariant();
    public string ValueUpper => RawValue.ToUpperInvariant();

    public CiString(string value)
    {
        RawValue = value;
    }

    public char this[int i]
    {
        get
        {
            return RawValue[i];
        }
    }

    public bool Equals(CiString other)
    {
        return RawValue.Equals(other.RawValue, StringComparisonMode);
    }

    public bool Equals([NotNullWhen(true)] string? other)
    {
        return RawValue.Equals(other, StringComparisonMode);
    }

    public bool Equals([NotNullWhen(true)] CiString? other)
    {
        if (other is null)
            return false;

        return Equals(other.Value);
    }

    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        if (obj is null)
            return false;

        if (obj is string stringValue)
            return Equals(stringValue);

        if (obj is CiString ciStringValue)
            return Equals(ciStringValue);

        return false;
    }

    public override int GetHashCode()
    {
        HashCode code = new();
        code.Add(Value);

        return code.ToHashCode();
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
        return new(str);
    }

    public static implicit operator string?(CiString? obj)
    {
        return obj?.RawValue;
    }

    public static implicit operator CiString?(string? str)
    {
        if (str is null)
            return null;

        return new(str);
    }

    public static bool operator ==(CiString a, CiString b)
    {
        return a.Equals(b);
    }

    public static bool operator !=(CiString a, CiString b)
    {
        return !(a == b);
    }

    public static bool operator ==(CiString? a, CiString? b)
    {
        if (a is null || b is null)
            return a is null && b is null;

        return a.Value == b.Value;
    }

    public static bool operator !=(CiString? a, CiString? b)
    {
        return !(a == b);
    }
}
