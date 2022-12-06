using DesignPatterns.Adapter.Problem;
using DesignPatterns.Adapter.Problem.RegulatorALibrary;

namespace DesignPatterns.Adapter.ObjectAdapter;

internal class RegulatorAReportingServiceAdapter : IRegulatorAReportingServiceAdapter
{
    private RegulatorAReportingService _regulatorAService = new();

    public void ReportUserCreation(User user)
    {
        //Adapter code is written only once - inside the adapter.
        var userActivityA = new UserActivityA
        {
            UserEmail = user.Email,
            Username = user.UserName,
            OperationDate = DateTime.Now.ToShortDateString()
        };

        _regulatorAService.ReportUserCreation(userActivityA);
    }

    public void ReporUserLogin(User user)
    {
        var userActivityA = new UserActivityA
        {
            UserEmail = user.Email,
            Username = user.UserName,
            OperationDate = DateTime.Now.ToShortDateString()
        };

        _regulatorAService.ReportUserLogin(userActivityA);
    }
}
