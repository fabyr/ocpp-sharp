using System;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Reflection;
using System.Net.Sockets;

namespace OcppSharp
{
    public static class Util
    {
        private static readonly Regex idRegex = new Regex(@"^.+?.\/(.+?)\/?$", RegexOptions.Compiled);
        private static readonly Regex subPathRegex = new Regex(@"^(\/.+\/).+$", RegexOptions.Compiled);
        private static readonly Random _rnd = new Random();

        public static long NewID64()
        {
            byte[] data = new byte[8];
            using(var rng = RandomNumberGenerator.Create())
                rng.GetBytes(data);
            return BitConverter.ToInt64(data, 0);
        }

        public static long NewID32()
        {
            byte[] data = new byte[4];
            using(var rng = RandomNumberGenerator.Create())
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
            return idRegex.Match(requestLine ?? string.Empty).Groups[1].Value.Split('/').Last();
        }

        public static string SubPathFromRequestLine(string? requestLine)
        {
            return subPathRegex.Match(requestLine ?? string.Empty).Groups[1].Value;
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
            switch (ver)
            {
                case ProtocolVersion.OCPP16:
                    return "ocpp1.6";
                case ProtocolVersion.OCPP201:
                    return "ocpp2.0.1";
                default:
                    throw new ArgumentException();
            }
        }
    }
}