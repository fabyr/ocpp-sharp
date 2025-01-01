using OcppSharp.Server;
using OcppSharp.Protocol.Version16.RequestPayloads;
using OcppSharp.Protocol.Version16.ResponsePayloads;

namespace OcppSharp.Examples.Server;

public class Program
{
    private static readonly ManualResetEvent _closeEvent = new(false);

    public static void Main(string[] args)
    {
        Console.CancelKeyPress += (s, e) =>
        {
            e.Cancel = true;
            Console.WriteLine("Ctrl+C detected. Shutting down...");
            _closeEvent.Set();
        };

        const int port = 8000;

        // set up a server to listen on port 8000
        // Stations will be connecting to ws://<Hostname>/ocpp16/<Station ID>
        OcppSharpServer server = new("/ocpp16", ProtocolVersion.OCPP16, port);
        //server.Log = null; // Disable console logging
        server.RegisterHandler<BootNotificationRequest>((server, sender, req) =>
        {

            Console.WriteLine($"Received BootNotification! (Message ID = {req.FullRequest!.MessageId})");
            Console.WriteLine($"Vendor: {req.ChargePointVendor}");
            Console.WriteLine($"Serial Number: {req.ChargePointSerialNumber}");
            // ...

            // Always need to send a response
            return new BootNotificationResponse()
            {
                CurrentTime = DateTime.Now,
                Interval = 90 // Heartbeat Interval
            };
        });

        server.Start();
        Console.WriteLine($"Server started on port {port}!");
        _closeEvent.WaitOne();
        server.Stop();
    }
}
