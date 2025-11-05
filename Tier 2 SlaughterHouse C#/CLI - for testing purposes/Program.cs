using SlaughterhouseCLI;

namespace SlaughterHouse.CLI;

internal static class Program
{
    public static void Main(string[] args)
    {
        var app = new CliApp();
        app.Start();
    }
}