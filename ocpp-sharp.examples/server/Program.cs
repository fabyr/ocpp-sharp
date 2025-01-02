using OcppSharp.Server;
using OcppSharp.Protocol.Version16.RequestPayloads;
using OcppSharp.Protocol.Version16.ResponsePayloads;
using OcppSharp.Protocol;

namespace OcppSharp.Examples.Server;

public class Program
{
    private static readonly ManualResetEvent _closeEvent = new(false);

    private static readonly bool enableLogging = true;

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

        if (!enableLogging)
        {
            // Disable console logging by the server
            server.Log = null;
        }

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

        server.ClientAccepted += (sender, station) =>
        {
            Console.WriteLine($"New station connected: {station.Id}");

            // Accessing other connected clients
            Console.WriteLine($"Total connections: {server.ConnectedClients.Count}");
            Console.WriteLine($"All station IP addresses: {string.Join(", ", server.ConnectedClients.Select(client => client.EndPoint))}");

            // Example of sending a request to some station.
            // A delay of 3000ms is supposed to simulate a random event to show usage.
            // This could also be run outside of any handler/event. 
            // You just need a reference to some station. (OcppClientConnection)
            // e.g. with server.ConnectedClients or server.GetStation(id)
            Task.Run(async () =>
            {
                await Task.Delay(3000);
                Console.WriteLine($"Fetching configuration for '{station.Id}'...");

                Response rawResponse = await station.SendRequestAsync(new GetConfigurationRequest());
                GetConfigurationResponse response = (GetConfigurationResponse)rawResponse.Payload!;

                Console.WriteLine(
                    "Got configuration for '{0}': {1}",
                    station.Id,
                    string.Join(", ",
                        response.ConfigurationKey?.Select(entry => $"{entry.Key}={entry.Value}") ?? []
                    )
                );
            });
        };

        server.Start();
        Console.WriteLine($"Server started on port {port}!");
        _closeEvent.WaitOne();
        server.Stop();
    }
}
