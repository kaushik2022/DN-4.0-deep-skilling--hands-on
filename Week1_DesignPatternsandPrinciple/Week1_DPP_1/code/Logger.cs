using System;

public class Logger
{
    private static Logger singleLogger = null;

    private Logger()
    {
        Console.WriteLine("Logger has been initialized.");
    }

    public static Logger GetLogger()
    {
        if (singleLogger == null)
        {
            singleLogger = new Logger();
        }
        return singleLogger;
    }

    public void WriteLog(string msg)
    {
        Console.WriteLine("Message Logged: " + msg);
    }
}
