namespace Plugins;

public class PluginLoader<T> where T : IPlugin
{
    private List<T> _plugins = new List<T>();

    public void Load(T plugin)
    {
        _plugins.Add(plugin);
        Console.WriteLine($"Loaded plugin : {plugin.PluginName}");
    }

    public void ExecuteAll()
    {
        foreach(var p in _plugins)
            p.Execute();
    }

    public List<T> GetAll() => _plugins;
}
