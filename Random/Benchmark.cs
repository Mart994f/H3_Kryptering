using System;
using System.Diagnostics;

namespace Random
{
    class Benchmark : IDisposable
    {
        private Stopwatch _stopwatch = new Stopwatch();
        private string _testName;

        public Benchmark(string testName)
        {
            _stopwatch.Reset();
            _stopwatch.Start();
            _testName = testName;
        }

        public void Dispose()
        {
            _stopwatch.Stop();
            Console.WriteLine($"Elapsed Time for {_testName}: {_stopwatch.Elapsed}");
        }
    }
}
