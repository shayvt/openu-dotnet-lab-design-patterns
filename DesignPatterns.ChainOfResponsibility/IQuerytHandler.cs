namespace DesignPatterns.ChainOfResponsibility;

internal interface IQueryHandler
{
    IQueryHandler Next { get; set; }

    void Handle(Query query);
}
