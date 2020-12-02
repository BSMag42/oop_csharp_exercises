using System;

namespace TechReturners.Exercises
{
    public interface ICat
    {
        void GoToSleep();
        void WakeUp();
        bool IsAsleep{ get; }
        string Setting { get; }
        int AverageHeight { get; }
        string Eat { get; }
    }
}
