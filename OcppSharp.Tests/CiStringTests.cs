using System.Globalization;
using System.Text;

namespace OcppSharp.Tests;

public class CiStringTests
{
    private static string GetFullCharsetString()
    {
        byte[] bytes = [.. Enumerable.Range(byte.MinValue, byte.MaxValue - byte.MinValue).Select(v => (byte)v)];
        return Encoding.GetEncoding("ISO-8859-1").GetString(bytes);
    }

    [InlineData("abc", "abc", true)]
    [InlineData("abc", "abd", false)]
    [InlineData("aBc", "abC", true)]
    [InlineData("This is a test message.", "tHIs iS A tEst mEssaGe.", true)]
    [InlineData("This is a test message.", "This is a test message", false)]
    [InlineData("This is a test message.", "tHIs iS A tEst mEssaGe", false)]
    [Theory]
    public void TestEquality(string aValue, string bValue, bool expected)
    {
        CiString a = new(aValue);
        CiString b = new(bValue);

        Assert.Equal(a == b, expected);
        Assert.Equal(a != b, !expected);

        Assert.Equal(a.Equals(b), expected);
    }


    [Fact]
    public void TestEqualityFullCharset()
    {
        string value = GetFullCharsetString();

        CultureInfo culture = CultureInfo.InvariantCulture;

        (string, string, bool)[] testCases = [
            (value.ToLower(culture), value.ToUpper(culture), true),
            (value.ToUpper(culture), value.ToUpper(culture), true),
            (value.ToLower(culture), value.ToLower(culture), true),
            (value, value.ToLower(culture), true),
            (value, value.ToUpper(culture), true)
        ];

        foreach (var (aValue, bValue, expected) in testCases)
        {
            CiString a = new(aValue), b = new(bValue);

            Assert.Equal(a == b, expected);
            Assert.Equal(a != b, !expected);
            Assert.Equal(a.Equals(b), expected);
        }
    }

    [InlineData("abc")]
    [InlineData("aBc")]
    [InlineData("This is a test message.")]
    [InlineData("tHIs iS A tEst mEssaGe.")]
    [Theory]
    public void TestRawValueRetention(string value)
    {
        CiString ciString = new(value);
        Assert.Equal(ciString.RawValue, value);
    }

    [Fact]
    public void TestRawValueRetentionFullCharset()
    {
        string value = GetFullCharsetString();

        CiString ciString = new(value);
        Assert.Equal(ciString.RawValue, value);
    }
}
