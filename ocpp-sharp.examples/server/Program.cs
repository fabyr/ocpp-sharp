using Microsoft.Extensions.Logging;
using OcppSharp.Protocol;
using OcppSharp.Protocol.Version16.RequestPayloads;
using OcppSharp.Protocol.Version16.ResponsePayloads;
using OcppSharp.Server;

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

        // Set the loggerFactory paramter to null when creating the server instance for no logging.
        using ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
            builder.SetMinimumLevel(LogLevel.Debug);
        });

        // set up a server to listen on port 8000
        // Stations will be connecting to ws://<Hostname>/ocpp/<Station ID>
        OcppSharpServer server = new("/ocpp", [ProtocolVersion.OCPP201, ProtocolVersion.OCPP16], port, loggerFactory);

        server.RegisterHandler<BootNotificationRequest>((server, sender, request) =>
        {
            Console.WriteLine($"Received BootNotification! (Message ID = {request.FullRequest!.MessageId})");
            Console.WriteLine($"Vendor: {request.ChargePointVendor}");
            Console.WriteLine($"Serial Number: {request.ChargePointSerialNumber}");
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