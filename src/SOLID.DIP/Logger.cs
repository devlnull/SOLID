using System;

namespace SOLID.DIP;

public class Logger : ILogger
{
    public void Log(string logMessage)
    {
        Console.WriteLine(logMessage);
    }
}