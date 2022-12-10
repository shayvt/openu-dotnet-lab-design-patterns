namespace DesignPatterns.ChainOfResponsibility;

internal class QueryCacheHandler : IQueryHandler
{
    public IQueryHandler Next { get; set; }

    public void Handle(Query query)
    {
        var cacheItem = MyCache.Get(query.RowNumber);

        if (cacheItem != null)
        {
            Console.WriteLine($"Row number {query.RowNumber} retrieved from cache: {cacheItem}");
            return;
        }

        if (Next != null)
            Next.Handle(query);
    }
}
