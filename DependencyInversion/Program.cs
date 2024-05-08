namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* New instance of the FileLogger class and assigning it to a variable called logger.
             *
            */
            ILogger logger = new FileLogger();

            /* Creates a new instance of the CustomerService class and passes the logger instance as a parameter to its constructor.
             * The CustomerService class implements the ICustomerService interface and requires an instance of an ILogger implementation to be provided during instantaiton.
             * */
            ICustomerService customerService = new CustomerService(logger);

            /* Calls the Add method on the customerService object. Since customerService is an instance of the CustomerService class, the Add method defined in the CustomerService class is invoked.
             */
            customerService.Add();
        }
    }
}
