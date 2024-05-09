namespace DependencyInversion
{
    public class Program
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

            // Create some sample products
            Product laptop = new Product(1, "Laptop", 999.99m);
            Product phone = new Product(2, "Phone", 499.99m);
            Product headphones = new Product(3, "Headphones", 99.9m);

            // Create a new shopping cart
            ICart cart = new Cart();

            // Add products to the cart
            cart.AddProduct(laptop, 1);
            cart.AddProduct(phone, 2);
            cart.AddProduct(headphones, 1);

            Console.WriteLine(laptop);
            Console.WriteLine(phone);
            Console.WriteLine(headphones);

            // Calculate and display the total price
            decimal totalPrice = cart.CalculateTotal();
            Console.WriteLine($"Total Price: ${totalPrice}");
        }
    }
}
