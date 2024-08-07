# ocpp-sharp
An implementation of the [Open Charge Point Protocol](https://openchargealliance.org/protocols/open-charge-point-protocol/) (`OCPP`) in C#.

Supported Versions:
- Ocpp 1.6
- Ocpp 2.0.1

## Table of contents
- [Dependencies](#dependencies)
- [Features](#features)
- [What it isn't](#what-it-isnt)
- [Possible use cases](#possible-use-cases)
- [Running the Examples](#running-the-examples)
- [Basic Server Code](#basic-server-code)
- [Motivation](#motivation)

## Dependencies
- Newtonsoft.Json
- .NET 8

## Features
- C# Classes for all messages of the OCPP-Protocol.
- Easy to set up server and event system for processing messages.

## What it isn't
It's not a ready-to-go backend server. You still have to implement what happens once an OCPP-Message has been received and how respond accordingly.

## Possible use cases
- Automating certain ocpp-communication
- Emulating a charge point
- Implementation of a basic backend server for charge points

## Running the Examples
A minimalistic client and server example can be found under [/ocpp-sharp.examples](/ocpp-sharp.examples)

Running the functionality test (Single test message communication on `localhost`):
```
cd ./ocpp-sharp.examples/server
dotnet run
```

```
cd ./ocpp-sharp.examples/client
dotnet run
```

## Basic Server Code
```cs
using System;
using OcppSharp;
using OcppSharp.Server;
using OcppSharp.Protocol.Version16.RequestPayloads;
using OcppSharp.Protocol.Version16.ResponsePayloads;

namespace OcppApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // set up a server to listen on port 80
            // Stations will be connecting to ws://<Hostname>/ocpp16/<Station ID>
            OcppSharpServer server = new OcppSharpServer("/ocpp16", ProtocolVersion.OCPP16, 80);
            server.Log = null; // Disable console logging
            server.RegisterHandler<BootNotificationRequest>((server, sender, req) => {

                Console.WriteLine($"Received BootNotification! (Message ID = {req.FullRequest!.MessageId})");
                Console.WriteLine($"Vendor: {req.chargePointVendor}");
                Console.WriteLine($"Serial Number: {req.chargePointSerialNumber}");
                // ...

                // Always need to send a response
                return new BootNotificationResponse()
                {
                    currentTime = DateTime.Now,
                    interval = 90 // Heartbeat Interval
                };
            });

            server.Start();
            Console.WriteLine("Server started!");
            Console.ReadLine();
            server.Stop();
        }
    }
}
```

## Motivation
This project was part of a private OCPP-Backend project.
It was then split up into its own project here.
