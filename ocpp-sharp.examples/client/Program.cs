using System;
using OcppSharp;
using OcppSharp.Client;
using OcppSharp.Protocol;
using OcppSharp.Protocol.Version16.RequestPayloads;
using OcppSharp.Protocol.Version16.ResponsePayloads;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Examples.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            using(OcppSharpClient client = new OcppSharpClient("ws://localhost:8000/ocpp16/example_id_1234", ProtocolVersion.OCPP16))
            {
                // Example handler
                client.RegisterHandler<GetConfigurationRequest>((client, resp) => 
                {
                    Console.WriteLine("Got a GetConfiguration request from the server.");

                    return new GetConfigurationResponse()
                    {
                        configurationKey = new[] { new KeyValue() { key = "Example", value = "Config" } }
                    };
                });

                client.Connect();

                // Send a boot notification
                Response resp = await client.SendRequestAsync(new BootNotificationRequest()
                {
                    chargePointVendor = "example",
                    chargePointModel = "example-model",
                    firmwareVersion = "1.0"
                });

                BootNotificationResponse? payload = resp.Payload as BootNotificationResponse;

                // Do something with the payload...

                // Example output of full json
                Console.WriteLine($"Got BootNotification response: {resp.BaseJson}");

                Console.ReadLine();
                client.Disconnect();
                Console.WriteLine("Stopped.");
            }
        }
    }
}