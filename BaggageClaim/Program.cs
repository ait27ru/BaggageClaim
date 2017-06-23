using System;

namespace BaggageClaim
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var provider = new BaggageHandler();
            var observer1 = new ArrivalsMonitor("BaggageClaimMonitor1");
            var observer2 = new ArrivalsMonitor("SecurityExit");

            provider.BaggageStatus(712, "Detroit", 3);
            observer1.Subscribe(provider);
            provider.BaggageStatus(712, "Kalamazoo", 3);
            provider.BaggageStatus(400, "New York-Kennedy", 1);
            provider.BaggageStatus(712, "Detroit", 3);
            observer2.Subscribe(provider);
            provider.BaggageStatus(511, "San Francisco", 2);
            provider.BaggageStatus(712);
            observer2.Unsubscribe();
            provider.BaggageStatus(400);
            provider.LastBaggageClaimed();

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}