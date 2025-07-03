using System;

class Program
{
    static void Main(string[] args)
    {
        Logger firstLogger = Logger.GetLogger();
        firstLogger.WriteLog("System started.");

        Logger secondLogger = Logger.GetLogger();
        secondLogger.WriteLog("User logged in.");

        if (firstLogger == secondLogger)
        {
            Console.WriteLine("Confirmed: One logger instance is used.");
        }
        else
        {
            Console.WriteLine("Error: Multiple logger instances is used.");
        }
    }
}
