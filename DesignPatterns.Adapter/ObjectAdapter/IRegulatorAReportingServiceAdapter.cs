using DesignPatterns.Adapter.Problem;

namespace DesignPatterns.Adapter.ObjectAdapter;

internal interface IRegulatorAReportingServiceAdapter
{
    void ReportUserCreation(User user);

    void ReporUserLogin(User user);
}
