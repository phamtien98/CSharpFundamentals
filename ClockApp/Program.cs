using System;
namespace ClockApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            DisplayClock display = new DisplayClock();
            display.Subscribe(clock);
            ClockLogToFiles logToFile = new ClockLogToFiles();
            logToFile.Subcribe(clock);
            clock.Run();
        }
    }
}
