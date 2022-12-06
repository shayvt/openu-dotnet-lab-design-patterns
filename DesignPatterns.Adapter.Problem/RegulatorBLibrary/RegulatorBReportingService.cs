namespace DesignPatterns.Adapter.Problem.RegulatorALibrary;

/// <summary>
/// 3rd party library for reporting activity to regulator B
/// </summary>
internal class RegulatorBReportingService
{
    public void ReportUserBanned(UserActivityB userActivity)
    {
        Console.WriteLine($"User banned reported to RegulatorB: {userActivity.Username}, {userActivity.OperationDate}");
    }
}