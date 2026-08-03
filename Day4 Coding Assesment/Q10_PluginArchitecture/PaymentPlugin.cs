namespace Plugins.Payment;

using Plugins;

public class PaymentPlugin : IPlugin
{
    public string PluginName => "PaymentPlugin";

    public void Execute()
    {
        Console.WriteLine("[PaymentPlugin] Processing payment...");
    }
}
