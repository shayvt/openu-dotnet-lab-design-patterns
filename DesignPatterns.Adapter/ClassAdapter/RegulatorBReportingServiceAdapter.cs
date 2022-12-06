using DesignPatterns.Adapter.Problem;
using DesignPatterns.Adapter.Problem.RegulatorALibrary;

namespace DesignPatterns.Adapter.ObjectAdapter;

internal class RegulatorBReportingServiceAdapter : RegulatorBReportingService, IRegulatorBReportingServiceAdapter
{
    public void ReporUserBanned(User user)
    {
        var userActivity = new UserActivityB
        {
            Username = user.UserName,
            OperationDate = DateTime.Now
        };

        ReportUserBanned(userActivity);
    }
}
