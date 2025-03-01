using System.Net.WebSockets;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace OcppSharp.Abstractions;

public class WebSocketTransceiver : Transceiver, IDisposable
{
    private readonly ILogger<WebSocketTransceiver> _logger;
    private readonly ILoggerFactory _loggerFactory;

    public WebSocket Socket { get; }

    /// <summary>
    /// The encoding used for encoding and decoding WebSocket data.
    /// <para>Defaults to <see cref="Encoding.UTF8"/></para>
    /// </summary>
    public static Encoding Encoding { get; set; } = Encoding.UTF8;

    public int MaxIncomingDataValue { get; set; } = 32767;

    private bool _stopLoop = false;

    public WebSocketTransceiver(WebSocket socket, ILoggerFactory? loggerFactory = null)
    {
        Socket = socket;

        _loggerFactory = loggerFactory ?? NullLoggerFactory.Instance;
        _logger = _loggerFactory.CreateLogger<WebSocketTransceiver>();
    }

    public async void StartMessageLoop(CancellationToken cancellationToken)
    {
        _logger.LogDebug("Client loop start.");
        _stopLoop = false;
        byte[]? receiveBuffer = null;
        try
        {
            while (!_stopLoop && !cancellationToken.IsCancellationRequested && Socket.State == WebSocketState.Open)
            {
                // update the size of the buffer if MaxIncomingDataValue changes
                if (receiveBuffer?.Length != MaxIncomingDataValue)
                    receiveBuffer = new byte[MaxIncomingDataValue];

                WebSocketReceiveResult receiveResult = await Socket.ReceiveAsync(new ArraySegment<byte>(receiveBuffer, 0, receiveBuffer.Length), cancellationToken);

                if (receiveResult.MessageType == WebSocketMessageType.Close)
                {
                    if (Socket.State == WebSocketState.CloseReceived)
                        await Socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, string.Empty, cancellationToken);

                    // Wait for close-handshake completion
                    while (Socket.State == WebSocketState.CloseReceived)
                        await Task.Delay(10, cancellationToken);

                    break;
                }
                else if (receiveResult.MessageType == WebSocketMessageType.Text)
                {
                    string text = Encoding.GetString(receiveBuffer, 0, receiveResult.Count);

                    // Process
                    InvokeOnReceive(text, cancellationToken);
                }
                else
                {
                    await Socket.CloseOutputAsync(WebSocketCloseStatus.InvalidMessageType, "Cannot accept binary data", cancellationToken);

                    // Wait for close-handshake completion
                    while (Socket.State == WebSocketState.CloseSent)
                        await Task.Delay(10, cancellationToken);

                    break;
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "WebSocket Error");
        }
        _logger.LogDebug("Client loop stop.");
    }

    public void StopMessageLoop()
    {
        _stopLoop = true;
    }

    public override async Task Send(string message, CancellationToken cancellationToken)
    {
        byte[] messageBytes = Encoding.GetBytes(message);
        await Socket.SendAsync(new ArraySegment<byte>(messageBytes, 0, messageBytes.Length), WebSocketMessageType.Text, true, cancellationToken);
    }

    public void Dispose()
    {
        Socket.Dispose();
        GC.SuppressFinalize(this);
    }
}
