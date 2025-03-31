# ocpp-sharp
An implementation of the [Open Charge Point Protocol](https://openchargealliance.org/protocols/open-charge-point-protocol) (`OCPP`) in C#.

Currently supported versions:
- Ocpp 1.6
- Ocpp 2.0.1

## Table of contents
- [ocpp-sharp](#ocpp-sharp)
  - [Table of contents](#table-of-contents)
  - [Dependencies](#dependencies)
  - [Features](#features)
  - [What it isn't](#what-it-isnt)
  - [Possible use cases](#possible-use-cases)
  - [Running the examples](#running-the-examples)
  - [Basic server code](#basic-server-code)
  - [Motivation](#motivation)

## Dependencies
- Newtonsoft.Json
- .NET 8

## Features
- C# classes for all messages of the OCPP-Protocol.
- Easy to set up server and event system for processing messages.

## What it isn't
It's not a ready-to-go backend server. You still have to implement what happens once an OCPP-Message has been received and how respond accordingly.

## Possible use cases
- Automating certain ocpp-communication
- Emulating a charge point
- Implementation of a basic backend server for charge points

## Running the examples
A minimalistic client and server example can be found under [/ocpp-sharp.examples](/ocpp-sharp.examples)

Start the server:
```shell
cd ./ocpp-sharp.examples/server
dotnet run
```

And then a client:
```shell
cd ./ocpp-sharp.examples/client
dotnet run
```

The examples are preconfigured to connect to each other on `localhost:8000` \
and exchange some example messages.

## Basic server code
```cs
using OcppSharp.Server;
using OcppSharp.Protocol.Version16.RequestPayloads;
using OcppSharp.Protocol.Version16.ResponsePayloads;
using OcppSharp.Protocol;

namespace OcppApp;

public class Program
{
    public static void Main(string[] args)
    {
        // Set up a server to listen on port 80
        // Stations will be connecting to ws://<Hostname>/ocpp16/<Station ID>
        OcppSharpServer server = new("/ocpp16", [ProtocolVersion.OCPP16], 80);

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

        server.Start();
        Console.WriteLine("Server started!");
        Console.ReadLine();
        server.Stop();
    }
}
```

## Motivation
This project was part of a private OCPP-Backend project.
It was then split up into its own project here.
