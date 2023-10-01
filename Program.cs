using System;
using System.Linq.Expressions;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Queue;


// array of string to store the message
string[] messages = new string[] { "First message", "Second message", "Third message" };

// stiorage account connection string
string storageConnectionString = "YOUR_STORAGE_CONNECTION_STRING";
// stiorage queue name
string queueName = "YOUR_QUEUE_NAME";

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

// stiorage queue message content
string messageContent = "Hello, Varcity College Students!";



// Create a message and add it to the queue
CloudQueueMessage message = new CloudQueueMessage(messageContent);
queue.AddMessage(message);

Console.WriteLine($"Message '{messageContent}' added to the queue '{queueName}'.");
