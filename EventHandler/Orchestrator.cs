using System.Collections.Concurrent;

namespace EventHandler
{
    public class Orchestrator
    {
        private readonly EventChannel _ec;
        public Orchestrator()
        {
            _ec = new EventChannel();
            _ec.EvenHandler += WriteToDb;
        }
        public void StartHandling()
        {
            _ec.Run();
        }

        void WriteToDb(object sender, string message)
        {
            Console.WriteLine("Processing the message....");
            var processedMessage = message.ToUpper();
            Task.Delay(2000).Wait();
            _ec.Store(processedMessage);
        }
    }
}
