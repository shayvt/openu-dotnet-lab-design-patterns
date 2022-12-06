using DesignPatterns.Adapter.ObjectAdapter;
using DesignPatterns.Adapter.Problem;

User user = new()
{
    UserName = "shay_vvv",
    FirstName = "Shay",
    Address = "Arlozerov",
    Country = "Israel",
    Email = "email@gmail.com",
    ZipCode = "12345"
};

IRegulatorAReportingServiceAdapter regulatorAServiceAdapter = new RegulatorAReportingServiceAdapter();

// Adapter uses our model object.
regulatorAServiceAdapter.ReporUserLogin(user);
regulatorAServiceAdapter.ReportUserCreation(user);


IRegulatorBReportingServiceAdapter regulatorBServiceAdapter = new RegulatorBReportingServiceAdapter();

// Adapter uses our model object.
regulatorBServiceAdapter.ReporUserBanned(user);