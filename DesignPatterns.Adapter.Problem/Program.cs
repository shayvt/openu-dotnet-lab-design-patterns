using DesignPatterns.Adapter.Problem;
using DesignPatterns.Adapter.Problem.RegulatorALibrary;

User user = new()
{
    UserName = "shay_vvv",
    FirstName = "Shay",
    Address = "Arlozerov",
    Country = "Israel",
    Email = "email@gmail.com",
    ZipCode = "12345"
};

// Report Login to regulator A - need to adjust the user to match the library
// Anywhere we call this, we need to do the adjustments.
RegulatorAReportingService regulatorAService = new();
var userActivityA = new UserActivityA
{
    UserEmail = user.Email,
    Username = user.UserName,
    OperationDate = DateTime.Now.ToShortDateString()
};

regulatorAService.ReportUserLogin(userActivityA);

//-----------------------

// Report Login to regulator B - need to adjust the user to match the second library
// Eache library has it's own input structure.
RegulatorBReportingService regulatorBService = new();
var userActivityB = new UserActivityB
{
    Username = user.UserName,
    OperationDate = DateTime.Now
};

regulatorBService.ReportUserBanned(userActivityB);

//-----------------------