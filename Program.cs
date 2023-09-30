using System;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Queue;


// array of string to store the message
string[] messages = new string[] { "First message", "Second message", "Third message" };

// storage account connection string
string storageConnectionString = "DefaultEndpointsProtocol=https;AccountName=st10147510rg9b42;AccountKey=9D1hUKwhYx8iBpSx+yKyjYNwwWCSP2eNVQ1zzzxY45zA/lpo14CIVXhOs8RkegaaqpPtlB5pzrYL+AStZt2XlQ==;EndpointSuffix=core.windows.net";
// storage queue name
string queueName = "st10147510-storage-queue";

// Create a CloudStorageAccount object from the connection string
CloudStorageAccount storageAccount = CloudStorageAccount.Parse(storageConnectionString);

// Create a CloudQueueClient object for interacting with the queue service
CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

// Get a reference to the queue
CloudQueue queue = queueClient.GetQueueReference(queueName);

// Create the queue if it doesn't exist
queue.CreateIfNotExists();

// Loop through the array of string
foreach (string message in messages)
{
    // Create a message and add it to the queue
    CloudQueueMessage queueMessage = new CloudQueueMessage(message);
    queue.AddMessage(queueMessage);
    Console.WriteLine($"Message '{message}' added to the queue '{queueName}'.");
}
