namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate Dependency Inversion by injecting different loggers into CustomerService.

            ILogger logger = new FileLogger();
            ICustomerService customerService = new CustomerService(logger);
            customerService.Add();

            // Use FileLogger
            ILogger fileLogger = new FileLogger();
            ICustomerService fileCustomerService = new CustomerService(fileLogger);
            fileCustomerService.Add();

            // Use EmailLogger
            ILogger emailLogger = new EmailLogger();
            ICustomerService emailCustomerService = new CustomerService(emailLogger);
            emailCustomerService.Add();
            // Use EventViewerLogger
            ILogger eventViewerLogger = new EventViewerLogger();
            ICustomerService eventViewerCustomerService = new CustomerService(eventViewerLogger);
            eventViewerCustomerService.Add();
        }
    }
}
