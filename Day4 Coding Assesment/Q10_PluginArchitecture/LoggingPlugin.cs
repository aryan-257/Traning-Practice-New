namespace Plugins.Logging;

using Plugins;

public class LoggingPlugin : IPlugin
{
    public string PluginName => "LoggingPlugin";

    public void Execute()
    {
        Console.WriteLine("[LoggingPlugin] Writing logs...");
    }
}
