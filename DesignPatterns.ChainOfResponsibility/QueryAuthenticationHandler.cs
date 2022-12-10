namespace DesignPatterns.ChainOfResponsibility;

internal class QueryAuthenticationHandler : IQueryHandler
{
    public IQueryHandler Next { get; set; }

    public void Handle(Query query)
    {
        if (query.Username != "admin")
        {
            Console.WriteLine($"Isufficient permissions to query with user {query.Username}");
            return;
        }

        if (Next!= null)
        {
            Next.Handle(query);
        }
    }
}
