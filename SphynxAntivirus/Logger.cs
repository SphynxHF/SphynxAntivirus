using System;
using System.IO;

public static class Logger
{
    private static readonly string logFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs.txt");

    public static void Log(string message)
    {
        try
        {
            string entry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            File.AppendAllText(logFile, entry + Environment.NewLine);
        }
        catch
        {
            // Optionally: handle logging failure (e.g., locked file)
        }
    }

    public static string[] GetLogEntries()
    {
        if (!File.Exists(logFile)) return new string[0];
        return File.ReadAllLines(logFile);
    }

    public static void ClearLogs()
    {
        if (File.Exists(logFile))
            File.WriteAllText(logFile, string.Empty);
    }
}
