using OcppSharp.Client;
using OcppSharp.Protocol;
using OcppSharp.Protocol.Version16.RequestPayloads;
using OcppSharp.Protocol.Version16.ResponsePayloads;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Examples.Client;

public class Program
{
    private static readonly ManualResetEvent _closeEvent = new(false);

    public static async Task Main(string[] args)
    {
        Console.CancelKeyPress += (s, e) =>
        {
            e.Cancel = true;
            Console.WriteLine("Ctrl+C detected. Shutting down...");
            _closeEvent.Set();
        };

        const string stationId = "example_id_1234";
        const string serverUrl = $"ws://localhost:8000/ocpp16/{stationId}";

        using (OcppSharpClient client = new(stationId, ProtocolVersion.OCPP16))
        {
            // Example handler
            client.RegisterHandler<GetConfigurationRequest>((client, resp) =>
            {
                Console.WriteLine("Got a GetConfiguration request from the server.");

                if (resp.Key != null)
                    throw new NotImplementedException();

                return new GetConfigurationResponse()
                {
                    ConfigurationKey = [
                        new KeyValue() { Key = "ExampleKey", Value = "ConfigValue" },
                        new KeyValue() { Key = "ExampleKey2", Value = "ExampleValue2", ReadOnly = true }
                    ]
                };
            });

            client.Closed += (sender, e) =>
            {
                Console.WriteLine("Client connection has been closed.");
                _closeEvent.Set();
            };

            await client.Connect(serverUrl);

            // Send a boot notification
            Response resp = await client.SendRequestAsync(new BootNotificationRequest()
            {
                ChargePointVendor = "example",
                ChargePointModel = "example-model",
                FirmwareVersion = "1.0",
                ChargePointSerialNumber = "Test Serial"
            });

            BootNotificationResponse? payload = resp.Payload as BootNotificationResponse;

            // Do something with the payload...

            // Example output of full json
            Console.WriteLine($"Got BootNotification response: {resp.OriginalJsonBody}");

            _closeEvent.WaitOne();
            client.Disconnect();
            Console.WriteLine("Stopped.");
        }
    }
}
