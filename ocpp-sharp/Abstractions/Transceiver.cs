namespace OcppSharp.Abstractions;

public abstract class Transceiver 
{
    public event ReceiveCallback? OnReceive;

    protected void InvokeOnReceive(string message, CancellationToken cancellationToken)
    {
        OnReceive?.Invoke(message, cancellationToken);
    }

    public abstract Task Send(string message, CancellationToken cancellationToken);
}
