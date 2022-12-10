namespace DesignPatterns.ChainOfResponsibility;

internal static class MyCache
{
    // Not thread safe!
    private static readonly Dictionary<int, string> _cache = new();

    public static void Add(int key, string value)
    {
        _cache[key] = value;
    }

    public static string Get(int key)
    {
        if (_cache.TryGetValue(key, out var value))
            return value;

        return null;
    }
}
