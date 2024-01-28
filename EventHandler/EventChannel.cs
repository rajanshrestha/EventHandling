namespace EventHandler
{
    public class EventChannel
    {
        public event EventHandler<string?> EvenHandler;

        public async Task Run()
        {
            while (true)
            {
                if(MockQueue.QueueMessage.Any())
                {
                    Task.Delay(5000).Wait();
                    Console.WriteLine($"Found {MockQueue.QueueMessage.Count()} messages in the Queue.");
                    MockQueue.QueueMessage.TryDequeue(out string? message);
                    EvenHandler(this, $"{message?? string.Empty}");
                }
            }
        }

        public void Store(string processedMessage)
        {
            Console.WriteLine($"Storing Processed Message - \"{processedMessage.ToUpper()}\"");
        }

    }
}
