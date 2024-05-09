namespace DependencyInversion.Tests
{
    using DependencyInversion;
    public class CartTests
    {
        [Fact]
        public void AddProduct_ShouldAddProductsToCart()
        {
            // Arrange
            ICart cart = new Cart();
            Product product = new Product(1, "Laptop", 999.99m);

            // Act
            cart.AddProduct(product, 1);

            // Assert
            Assert.Single(((Cart)cart).GetItems()); // Ensure cart has one item
            Assert.Equal(1, ((Cart)cart).GetItems()[0].quantity); // Ensure quantity is correct
            Assert.Equal(product, ((Cart)cart).GetItems()[0].product); // Ensure product is correct
        }

        [Fact]
        public void UpdateQuantity_ShouldUpdateQuantityOfProductInCart()
        {
            // Arrange
            ICart cart = new Cart();
            Product product = new Product(1, "Laptop", 999.99m);
            cart.AddProduct(product, 1);

            // Act
            cart.UpdateQuantity(product, 2);

            // Assert
            Assert.Single(((Cart)cart).GetItems()); // Ensure cart still has one item
            Assert.Equal(2, ((Cart)cart).GetItems()[0].quantity); // Ensure quantity is updated
        }

        [Fact]
        public void RemoveProduct_ShouldRemoveProductFromCart()
        {
            // Arrange
            ICart cart = new Cart();
            Product product = new Product(1, "Laptop", 999.99m);
            cart.AddProduct(product, 1);

            // Act
            cart.RemoveProduct(product);

            // Assert
            Assert.Empty(((Cart)cart).GetItems()); // Ensure cart is empty
        }


        [Fact]
        public void CalculateTotal_ShouldReturnCorrectTotalPrice()
        {
            // Arrange
            ICart cart = new Cart();
            Product laptop = new Product(1, "Laptop", 999.99m);
            Product phone = new Product(2, "Phone", 499.99m);
            Product headphones = new Product(3, "Headphones", 99.99m);

            cart.AddProduct(laptop, 1);
            cart.AddProduct(phone, 2);
            cart.AddProduct(headphones, 1);

            // Act
            decimal totalPrice = cart.CalculateTotal();

            // Assert
            decimal expectedTotalPrice = laptop.Price + (phone.Price * 2) + headphones.Price;
            Assert.Equal(expectedTotalPrice, totalPrice);
        }
    }
}