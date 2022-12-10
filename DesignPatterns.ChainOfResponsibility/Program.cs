using DesignPatterns.ChainOfResponsibility;

QueryAuthenticationHandler queryHandler = new();
QueryCacheHandler cacheHandler = new();
QueryDbHandler queryDbHandler = new();

Query query1 = new()
{
    Username= "guest",
    RowNumber = 1,
};

Query query3 = new()
{
    Username = "admin",
    RowNumber = 3,
};

queryHandler.Next = cacheHandler;
cacheHandler.Next = queryDbHandler;

queryHandler.Handle(query1);
queryHandler.Handle(query1);

queryHandler.Handle(query3);
queryHandler.Handle(query3);