using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Reflection;

namespace OcppSharp;

public static partial class Util
{
    [GeneratedRegex(@"^.+?.\/(.+?)\/?$")]
    private static partial Regex IDRegex();

    [GeneratedRegex(@"^(\/.+\/).+$")]
    private static partial Regex SubPathRegex();

    public static long NewID64()
    {
        return BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 2);
    }

    public static long NewID32()
    {
        byte[] data = new byte[4];
        using (var rng = RandomNumberGenerator.Create())
            rng.GetBytes(data);
        return BitConverter.ToInt32(data, 0);
    }

    public static long NewID32Unsinged()
    {
        return NewID32() & 0x7FFFFFFF; // Make unsinged
    }

    public static string IdFromRequestLine(string? requestLine)
    {
        // TODO: Find better solution?
        return IDRegex().Match(requestLine ?? string.Empty).Groups[1].Value.Split('/').Last();
    }

    public static string SubPathFromRequestLine(string? requestLine)
    {
        return SubPathRegex().Match(requestLine ?? string.Empty).Groups[1].Value;
    }

    /// <summary>
    /// Waits for the task to complete, unwrapping any exceptions.
    /// </summary>
    /// <param name="task">The task. May not be <c>null</c>.</param>
    public static void WaitAndUnwrapException(this Task task)
    {
        try
        {
            task.Wait();
        }
        catch (AggregateException ex)
        {
            throw PrepareForRethrow(ex.InnerException!);
        }
    }

    /// <summary>
    /// Attempts to prepare the exception for re-throwing by preserving the stack trace. The returned exception should be immediately thrown.
    /// </summary>
    /// <param name="exception">The exception. May not be <c>null</c>.</param>
    /// <returns>The <see cref="Exception"/> that was passed into this method.</returns>
    public static Exception PrepareForRethrow(Exception exception)
    {
        System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(exception).Throw();

        // The code cannot ever get here. We just return a value to work around a badly-designed API (ExceptionDispatchInfo.Throw):
        //  https://connect.microsoft.com/VisualStudio/feedback/details/689516/exceptiondispatchinfo-api-modifications (http://www.webcitation.org/6XQ7RoJmO)
        return exception;
    }

    public static string? GetMessageIdentifier<T>()
    {
        return typeof(T).GetCustomAttribute<Protocol.OcppMessageAttribute>()?.Name;
    }

    public static string? GetMessageIdentifier(Type t)
    {
        return t.GetCustomAttribute<Protocol.OcppMessageAttribute>()?.Name;
    }

    public static string GetWebSocketSubProtocol(this ProtocolVersion ver)
    {
        return ver switch
        {
            ProtocolVersion.OCPP16 => "ocpp1.6",
            ProtocolVersion.OCPP201 => "ocpp2.0.1",
            _ => throw new ArgumentException("Invalid OCPP Protocol Version.", nameof(ver)),
        };
    }
}
