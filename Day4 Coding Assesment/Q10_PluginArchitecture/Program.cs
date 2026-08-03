using Plugins;
using Plugins.Tax;
using Plugins.Payment;
using Plugins.Logging;

var loader = new PluginLoader<IPlugin>();

loader.Load(new TaxPlugin());
loader.Load(new PaymentPlugin());
loader.Load(new LoggingPlugin());

Console.WriteLine("\nExecuting all plugins :");
loader.ExecuteAll();
