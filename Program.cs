// See https://aka.ms/new-console-template for more information


using System.Diagnostics;
using MethodTimer;
using System.Reflection;

await Test.TimedMethod();

public class Test
{
    [Time]
    public static async Task TimedMethod()
    {
        await Task.Delay(1000);
    }
}
public static class MethodTimeLogger
{
    public static void Log(MethodBase methodBase, long milliseconds, string message)
    {

        Debug.WriteLine($"Time Ms: {milliseconds}");
    }
}