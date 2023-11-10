using System.Net;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceLoanManager = new PersonalFinanceLoanManager();
            ICreditManager vehicleLoanManager = new VehicleLoanManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();
            ICreditManager tradesmanLoanManager = new TradesmanLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>()
            {
                databaseLoggerService,
                fileLoggerService,
                smsLoggerService
            };
            List<ICreditManager> credits = new List<ICreditManager>()
            {
                vehicleLoanManager,
                mortgageLoanManager,
                personalFinanceLoanManager
            };


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(vehicleLoanManager, loggers);
            Console.WriteLine("");
            Console.WriteLine("");
            applicationManager.CreditPreliminaryInformation(credits);


            Console.ReadKey();
        }
    }
}