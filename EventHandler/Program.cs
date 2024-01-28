using EventHandler;

Console.WriteLine("Type your message to place in the MockQueue.");

Orchestrator o = new Orchestrator();
Task.Factory.StartNew(() => o.StartHandling());
while (true)
{
    var message = Console.ReadLine();
    if(message != string.Empty)
    {
        MockQueue.QueueMessage.Enqueue(message);
    }
}

