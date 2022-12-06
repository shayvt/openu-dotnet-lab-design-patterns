namespace DesignPatterns.Adapter.Problem.RegulatorALibrary;

/// <summary>
/// 3rd party library for reporting activity to regulator A
/// </summary>
internal class RegulatorAReportingService
{
    public void ReportUserCreation(UserActivityA userActivity)
    {
        Console.WriteLine($"User creation reported to RegulatorA: {userActivity.Username}, {userActivity.UserEmail}, {userActivity.OperationDate}");
    }

    public void ReportUserLogin(UserActivityA userActivity)
    {
        Console.WriteLine($"User login reported to RegulatorA: {userActivity.Username}, {userActivity.UserEmail}, {userActivity.OperationDate}");
    }
}