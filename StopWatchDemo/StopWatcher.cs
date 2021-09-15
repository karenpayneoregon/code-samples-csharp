using System;
using System.Diagnostics;

namespace StopWatchDemo
{
    public sealed class StopWatcher
    {
        private static readonly Lazy<StopWatcher> Lazy = 
            new Lazy<StopWatcher>( () => new StopWatcher());

        private readonly Stopwatch _stopwatch;
        private StopWatcher() { _stopwatch = new Stopwatch(); }
        public void Start()
        {
            _stopwatch.Reset();
            _stopwatch.Start();
        }
        public void Stop() => _stopwatch.Stop();
        public TimeSpan Elapsed => _stopwatch.Elapsed;
        public string ElapsedFormatted => Elapsed.ToString("mm\\:ss\\.fff");
        public DateTime DateTime => DateTime.Now + Elapsed;
        public string DateTimeFormatted => DateTime.ToString("U");
        public static StopWatcher Instance => Lazy.Value;
        public override string ToString() => DateTimeFormatted;

    }
}