using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            for (var i = 0; i < 2; i++)
            {
                stopwatch.Start();
                Thread.Sleep(1000);

                stopwatch.Stop();

                Console.WriteLine(stopwatch.Duration());

                Console.WriteLine("Press Enter to run the stopwatch once more.");
                Console.ReadLine();
            }
        }
    }
}
