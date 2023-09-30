# QueueProducer Console Application

The QueueProducer is a .NET Core console application that allows you to send messages to an Azure Storage Queue. If the queue does not exist, it creates it.

## Introduction

This console application is designed to demonstrate how to interact with Azure Storage Queues using the Azure SDK for .NET Core. It allows you to send messages to a specified Azure Storage Queue. If the queue does not exist, it will be created automatically.

## Prerequisites

Before you begin, ensure you have met the following requirements:

- .NET Core SDK installed on your machine.
- An Azure Storage account with the connection string available.

## Installation

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/st10147510/QueueProducer.git   

```

2. Open a terminal or command prompt and navigate to the `QueueProducer` directory:

   ```bash
   cd QueueProducer
   ```

3. Modify the `Program.cs` file to set your Azure Storage connection string and queue name:

   ```csharp
   string storageConnectionString = "YOUR_STORAGE_CONNECTION_STRING";
   string queueName = "YOUR_QUEUE_NAME";
   ```

4. Save your changes.

## Usage

To run the application, open a terminal or command prompt in the `QueueProducer` directory and run the following command:

```bash
dotnet run
```

This will execute the console application. It will create the specified queue (if it does not exist) and send a sample message to the queue. You can customize the message content in the `Program.cs` file.

## Configuration

The configuration for this application is done within the `Program.cs` file. You need to provide your Azure Storage connection string and specify the queue name in this file.

```csharp
string storageConnectionString = "YOUR_STORAGE_CONNECTION_STRING";
string queueName = "YOUR_QUEUE_NAME";
```

Ensure that you have the correct connection string and queue name configured.
