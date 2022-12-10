namespace DesignPatterns.ChainOfResponsibility;

internal class QueryDbHandler : IQueryHandler
{
    private readonly List<string> _rows = new List<string>()
    {
        "Moshe",
        "Yossi",
        "Danni",
        "Shmuel",
        "Haim"
    };

    public IQueryHandler Next { get; set; }

    public void Handle(Query query)
    {
        if (query.RowNumber < _rows.Count)
        {
            Console.WriteLine($"Row number {query.RowNumber} retrieved from DB: {_rows[query.RowNumber]}");
            MyCache.Add(query.RowNumber, _rows[query.RowNumber]);

            return;
        }

        if (Next != null)
        {
            Next.Handle(query);
        }
    }
}
