namespace Plugins.Tax;

using Plugins;

public class TaxPlugin : IPlugin
{
    public string PluginName => "TaxPlugin";

    public void Execute()
    {
        Console.WriteLine("[TaxPlugin] Calculating tax...");
    }
}
